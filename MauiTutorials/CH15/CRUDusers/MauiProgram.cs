﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CRUDusers.Data;
using CRUDusers.Models;

namespace CRUDusers
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddDbContext<DataContext>(
                options =>
                {
                    var dbpath = Path.Combine(FileSystem.AppDataDirectory, "users.db");
                    options.UseSqlite($"Data Source={dbpath}");
                }
                ); // dependeny injection for DataContext

#if DEBUG
    		builder.Logging.AddDebug();

            var app = builder.Build();
#endif
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DataContext>();
                context.Database.EnsureCreated();

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { Name = "Alice" },
                        new User { Name = "Bob" },
                        new User { Name = "Charlie" }
                    );

                    context.SaveChanges();
                }
            }

            return app;
            
            
        }
    }
}
