using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Paton
{
    public partial class DisplayQuote : Form
    {
        private Form MainMenu;
        public DisplayQuote(Form MainMenu)
        {
            this.MainMenu = MainMenu;
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu.Show();
        }
    }
}
