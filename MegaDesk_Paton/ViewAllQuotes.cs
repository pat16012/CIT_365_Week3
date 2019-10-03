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
    public partial class ViewAllQuotes : Form
    {
        private Form MainMenu;
        public ViewAllQuotes(Form MainMenu)
        {
            this.MainMenu = MainMenu;
                InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu.Show();
        }
    }
}
