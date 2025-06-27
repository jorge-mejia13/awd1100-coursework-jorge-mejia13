using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOnTestCH06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> titles = new List<string> 
        { 
            "The Great Gatsby", 
            "War and Peace", 
            "Moby-Dick", 
            "Hamlet", 
            "Pride and Prejudice" 
        };
        List<string> keywords = new List<string>
        {
            "The story of eccentric millionaire Jay Gatsby and his pursuit of his lost love.",
            "A fictional story about the 1812 French invasion of Russia.",
            "The story of a sailor’s relentless hunt for a white whale.",
            "A Shakespearean tragedy about a young man coming home from college after the murder of his father.",
            "A comedic story of love and life in Old England."
        };
        List<string> authors = new List<string>
        {
            "F. Scott Fitzgerald",
            "Leo Tolstoy",
            "Herman Melville",
            "William Shakespeare",
            "Jane Austen"
        };
        List<string> isbns = new List<string>
        {
            "978-1847496140",
            "978-1400079988",
            "978-1503280786",
            "978-1973844402",
            "978-0141439518"
        };

        private void ShowBook(int index)
        {
            if (index >= 0)
            {
                nameLbl.Text = titles[index];
                descLbl.Text = keywords[index];
                authorLbl.Text = authors[index];
                isbnLbl.Text = isbns[index];
            }
        }

        private int SearchByAuthor(string authorName)
        {
            bool isBookFound = false;

            int index = -1;

            for (int i = 0; i < authors.Count && !isBookFound; i++)
            {
                if (authors[i].ToLower().Contains(authorName.ToLower()))
                {
                   
                    index = i;
                }
            }

            return index;
        }

        private int SearchByIsbn(string isbnNumber)
        {
            bool isBookFound = false;

            int index = -1;

            for (int i = 0;i < isbns.Count && !isBookFound; i++)
            {
                if (isbns[i].ToLower() == isbnNumber.ToLower())
                {
                    index = i;
                }
            }

            return index;
        }

        private int SearchByKeyword(string keyword)
        {
            bool isBookFound = false;

            int index = -1;
            
            for (int i = 0; i < keywords.Count && !isBookFound ; i++)
            {
                if (keywords[i].ToLower().Contains(keyword.ToLower()) || authors[i].ToLower().Contains(keyword.ToLower()))
                {
                    index = i;
                } 
            }

            return index;
        }

        private void authorSearchBtn_Click(object sender, EventArgs e)
        {
            int book = SearchByAuthor(authorInput.Text);
            ShowBook(book);
        }

        private void isbnSearchBtn_Click(object sender, EventArgs e)
        {
            int book = SearchByIsbn(isbnInput.Text);
            ShowBook(book);
        }

        private void keywordSearchBtn_Click(object sender, EventArgs e)
        {
            int book = SearchByKeyword(keywordInput.Text);
            ShowBook(book);
        }
    }
}
