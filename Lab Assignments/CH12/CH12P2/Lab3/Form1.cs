using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        List<Champion> champions = new List<Champion>()
        {
            new Champion("Ruckus", ChampionType.FRONT_LINE, new Ability("Miiniguns"), new Ability("Missile Launcher"), new Ability("Emitter"), new Ability("Advance"), new Ability("Hexa Fire")),
            new Champion("Makoa", ChampionType.FRONT_LINE, new Ability("Cannon"), new Ability("Dredge Anchor"), new Ability("Shell Shield"), new Ability("Shell Spin"), new Ability("Ancient Rage")),
            new Champion("Drogoz", ChampionType.DAMAGE, new Ability("Rocket Launcher"), new Ability("Fire Spit"), new Ability("Salvo"), new Ability("Thrust"), new Ability("Dragon Punch")),
            new Champion("Tyra", ChampionType.DAMAGE, new Ability("Auto Rifle"), new Ability("Nade Launcher"), new Ability("Fire Bomb"), new Ability("Hunter's Mark"), new Ability("Crossfire")),
            new Champion("Grover", ChampionType.SUPPORT, new Ability("Throwing Axe"), new Ability("Crippling Throw"), new Ability("Blossom"), new Ability("Vine"), new Ability("Whirlwind")),
            new Champion("Evie", ChampionType.FLANK, new Ability("Ice Staff"), new Ability("Ice Block"), new Ability("Blink"), new Ability("Soar"), new Ability("Ice Storm"))
        };

        public Form1()
        {
            InitializeComponent();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.ToLower();
            resultBox.Text = string.Empty;

            bool isFound = false;

            for (int i = 0; i < champions.Count; i++)
            {
                if (champions[i].Name.ToLower() == name)
                {
                    isFound = true;
                    resultBox.Text += $"{champions[i].Name}\n" + $"{champions[i].Type.ToString()}\n" + $"\n{champions[i].LeftMouse.Name}\n" + $"{champions[i].RightMouse.Name}\n" + $"\nQ:{champions[i].Q.Name}\n" + $"\nF:{champions[i].F.Name}\n" + $"\nE:{champions[i].E.Name}\n";
                }
            }

            if (!isFound)
            {
                resultBox.Text = "No chamption found";
            }
        }
    }
}
