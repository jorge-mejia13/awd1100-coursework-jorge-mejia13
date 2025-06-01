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
        public Form1()
        {
            InitializeComponent();

            //gridEmp1.Text = "";
            //gridEmp2.Text = "";
            //gridEmp3.Text = "";
        }
          

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            const double PERCENT_RAISE = 0.04;

            string name1 = employee1Name.Text;
            string name2 = employee2Name.Text;
            string name3 = employee3Name.Text;

            // 2018 salaries
            double salary1 = double.Parse(employee1Salary.Text);
            double salary2 = double.Parse(employee2Salary.Text);
            double salary3 = double.Parse(employee3Salary.Text);

            // 2019 salaries
            double salary12019 = salary1 + (salary1 * PERCENT_RAISE);
            double salary22019 = salary2 + (salary2 * PERCENT_RAISE);
            double salary32019 = salary3 + (salary3 * PERCENT_RAISE);

            // 2020 salaries
            double salary12020 = salary12019 + (salary12019 * PERCENT_RAISE);
            double salary22020 = salary22019 + (salary22019 * PERCENT_RAISE);
            double salary32020 = salary32019 + (salary22020 * PERCENT_RAISE);

            // add names to the column titles
            dataGrid.Columns[0].HeaderText = "Year";
            dataGrid.Columns[1].HeaderText = name1;
            dataGrid.Columns[2].HeaderText = name2;
            dataGrid.Columns[3].HeaderText = name3;


            // adds rows to the columns
            dataGrid.Rows.Add("2018", salary1.ToString("C"), salary2.ToString("C"), salary3.ToString("C"));
            dataGrid.Rows.Add("2019", salary12019.ToString("C"), salary22019.ToString("C"), salary32019.ToString("C"));
            dataGrid.Rows.Add("2020", salary12020.ToString("C"), salary22020.ToString("C"), salary32020.ToString("C"));  


        }
    }
}
