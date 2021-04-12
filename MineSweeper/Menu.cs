using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Bt_Jugar_Click(object sender, EventArgs e)
        {
            if (Rb_Principiante.Checked)
            {
                this.Visible = false;
                Form1 Juego = new Form1(8,8,10);
                Juego.Show();
                
            }
        }
    }
}
