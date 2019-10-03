using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Paton
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NewQuote_Click(object sender, EventArgs e)
        {
            //Application.Run(new AddNewQuote(this));
            Form addNewQuote = new AddQuote(this);
            addNewQuote.Show();
            Hide();
        }

        private void ViewQuote_Click(object sender, EventArgs e)
        {
            Form viewQuote = new ViewAllQuotes(this);
            viewQuote.Show();
            Hide();
        }

        private void SearchQuote_Click(object sender, EventArgs e)
        {
            Form searchQuote = new SearchQuotes(this);
            searchQuote.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
