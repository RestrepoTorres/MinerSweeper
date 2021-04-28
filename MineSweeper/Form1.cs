using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Destapar(Button button)
        {
            if (button != null&&!Convert.ToBoolean(button.Tag))
            {
                button.Tag = true;
                TableLayoutPanelCellPosition coordenadas = tableLayoutPanel1.GetCellPosition(button);

                if (button.Text == "X")
                {
                    //mostrar gameover
                }
                if (button.Text == "0")
                {
                    button.BackColor = System.Drawing.Color.White;
                    for (int n = -1; n <= 1; n++)
                    {
                        for (int o = -1; o <= 1; o++)
                        { 
                            try
                            {
                                Destapar(tableLayoutPanel1.GetControlFromPosition(coordenadas.Column + n, coordenadas.Row + o) as Button);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }     
                }
                button.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            
            Button button = sender as Button;
            Destapar(button);
            //button.Text = String.Format("({0} , {1})",coordenadas.Row + 1,coordenadas.Column + 1);
        }
    }
}
