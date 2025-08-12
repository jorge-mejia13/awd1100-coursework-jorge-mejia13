using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            float width = float.Parse(widthInput.Text);
            float height = float.Parse(heightInput.Text);

            if (unframedBtn.Checked)
            {
                Photo photo = new Photo(width, height);

                totalCostLbl.Text = $"Cost: ${photo.Price.ToString()}";
                resultLbl.Text = $"{photo.ToString()} Unframed";
            }
            else if (matteBtn.Checked) 
            {
                MattedPhoto mattedPhoto = null;

                if (blackBtn.Checked) { mattedPhoto = new MattedPhoto(width, height, Color.BLACK); }
                else if (redBtn.Checked) { mattedPhoto = new MattedPhoto(width, height, Color.RED); }
                else if (greenBtn.Checked) { mattedPhoto = new MattedPhoto(width, height, Color.GREEN); }
                else if (blueBtn.Checked) { mattedPhoto = new MattedPhoto(width, height, Color.BLUE); }
                else if (whiteBtn.Checked) { mattedPhoto = new MattedPhoto(width, height, Color.WHITE); }
                
                totalCostLbl.Text = $"Cost: ${mattedPhoto.Price.ToString()}";
                resultLbl.Text = $"{mattedPhoto.ToString()}";
            }
            else if (framedBtn.Checked)
            {
                FramedPhoto framedPhoto = null;
                Material selectedMaterial = Material.PINE;
                Style selectedStyle = Style.SIMPLE;

                if (pineBtn.Checked) selectedMaterial = Material.PINE;
                else if (oakBtn.Checked) selectedMaterial = Material.OAK;
                else if (steelBtn.Checked) selectedMaterial = Material.STEEL;
                else if (silverBtn.Checked) selectedMaterial = Material.SILVER;
                else if (goldBtn.Checked) selectedMaterial = Material.GOLD;

                if (simpleBtn.Checked) selectedStyle = Style.SIMPLE;
                else if (modernBtn.Checked) selectedStyle = Style.MODERN;
                else if (antiqueBtn.Checked) selectedStyle = Style.ANTIQUE;
                else if (vintageBtn.Checked) selectedStyle = Style.VINTAGE;
                else if (eclecticBtn.Checked) selectedStyle = Style.ECLECTIC;

                framedPhoto = new FramedPhoto(width, height, selectedMaterial, selectedStyle);

                totalCostLbl.Text = $"Cost: ${framedPhoto.Price.ToString()}";
                resultLbl.Text = $"{framedPhoto.ToString()}";
            }
        }
    }
}
