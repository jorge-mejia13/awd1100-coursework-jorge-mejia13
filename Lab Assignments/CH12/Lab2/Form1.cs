using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        string accessKey = "1234";

        int index = -1;

        InventoryItem[] items = new InventoryItem[20];
        public Form1()
        {
            InitializeComponent();

            items[0] = new InventoryItem("Hammer", 1001, 9.99m, 40.00m, 10);
            items[1] = new InventoryItem("Screwdriver", 1002, 5.49m, 30.00m, 20);
            items[2] = new InventoryItem("Drill", 1003, 49.99m, 200.00m, 4);
            items[3] = new InventoryItem("Wrench", 1004, 7.89m, 35.00m, 10);
            items[4] = new InventoryItem("Tape Measure", 1005, 3.99m, 24.00m, 12);
        }

        private void nameSearchBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.ToLower();

            bool isFound = false;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null && items[i].GetItemName().ToLower().Contains(name))
                {
                    isFound = true;
                    index = i;
                    nameLbl.Text = $"Name: {items[i].GetItemName()}";
                    upcLbl.Text = $"UPC: {items[i].GetUpc().ToString()}";
                    storePriceLbl.Text = $"Store Price: ${items[i].GetPrice().ToString()}";
                    costPerCaseLbl.Text = $"Cost Per Case: ${items[i].GetCostPerCase().ToString()}";
                    unitsPerCaseLbl.Text = $"Units Per Case: {items[i].GetUnitsPerCase().ToString()}";
                    return;
                }
            }

            if (!isFound)
            {
                nameLbl.Text = "No match found. Try again";
            }
        }

        private void upcSearchBtn_Click(object sender, EventArgs e)
        {

            bool isFound = false;

            if (int.TryParse(upcSearchInput.Text, out int upc))
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] != null && items[i].GetUpc() == upc)
                    {
                        isFound = true;
                        index = i;
                        nameLbl.Text = $"Name: {items[i].GetItemName()}";
                        upcLbl.Text = $"UPC: {items[i].GetUpc().ToString()}";
                        storePriceLbl.Text = $"Store Price: ${items[i].GetPrice().ToString()}";
                        costPerCaseLbl.Text = $"Cost Per Case: ${items[i].GetCostPerCase().ToString()}";
                        unitsPerCaseLbl.Text = $"Units Per Case: {items[i].GetUnitsPerCase().ToString()}";
                        return;
                    }
                }
            }

            if (!isFound)
            {
                nameLbl.Text = $"Upc was not found. Try agian";
            }
        }

        private void changeStorePriceBtn_Click(object sender, EventArgs e)
        {
            decimal newPrice = decimal.Parse(changeStorePriceInput.Text);

            if (accessKeyInput.Text == accessKey)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    items[index].SetPrice(newPrice);
                    errorLbl.Text = "New price added!";
                }
            }
            else
            {
                errorLbl.Text = "Incorrect access key";
            }

        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {

            if (accessKeyDeleteInput.Text != accessKey)
            {
                errorDeleteLbl.Text = "Incorrect Access Key";
            }


            if (int.TryParse(verifyUpcInput.Text, out int upc)) 
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] != null && items[i].GetUpc() == upc)
                    {
                        items[i] = null;
                        errorDeleteLbl.Text = "Item has been deleted";
                        return;
                    }
                }

                errorDeleteLbl.Text = "Incorrect UPC";
            } 
            else
            {
                errorDeleteLbl.Text = "Incorrect UPC";
            }
            
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string name = addNameInput.Text;
            int upc = int.Parse(addUpcInput.Text);
            decimal price = decimal.Parse(addStorePriceInput.Text);
            decimal costPerCase = decimal.Parse(addCostPerCaseInput.Text);
            int unitsPercase = int.Parse(addUnitsPerCaseInput.Text);
            
            string key = addAccessKeyInput.Text;

            if (key != accessKey)
            {
                addErrorLbl.Text = "Access Key Incorrect";
            }

            for (int i = 0;i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = new InventoryItem(name, upc, price, costPerCase, unitsPercase);
                    return;
                }
            }

            addErrorLbl.Text = "Inventory is full. Delete some items";
        }
    }
}
