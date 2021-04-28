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
                    Fin fin = new Fin("Fin del Juego");
                    fin.Show();
                    this.Close();
                    button.Text = "💣";
                    button.ForeColor = System.Drawing.Color.Red;
                    button.BackColor = System.Drawing.Color.Gray;
                } 
                if (button.Text == "0")
                {
                    this.casillas -= 1;
                    button.BackColor = System.Drawing.Color.White;
                    for (int n = -1; n <= 1; n++)
                    {
                        for (int o = -1; o <= 1; o++)
                        { 
                            try
                            {
                                Destapar(tableLayoutPanel1.GetControlFromPosition(coordenadas.Column + n, coordenadas.Row + o) as Button);
                                button.ForeColor = System.Drawing.Color.Gray;
                                button.BackColor = System.Drawing.Color.Gray;
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }     
                }
                else{
                    this.casillas -= 1;

                    switch (button.Text)
                    {
                        case "1":
                            button.ForeColor = System.Drawing.Color.Blue;
                            break;

                        case "2":
                            button.ForeColor = System.Drawing.Color.Green;
                            break;

                        case "3":
                            button.ForeColor = System.Drawing.Color.Red;
                            break;

                        case "4":
                            button.ForeColor = System.Drawing.Color.DarkBlue;
                            break;

                        case "5":
                            button.ForeColor = System.Drawing.Color.DarkRed;
                            break;

                        case "6":
                            button.ForeColor = System.Drawing.Color.DarkCyan;
                            break;

                        case "7":
                            button.ForeColor = System.Drawing.Color.Black;
                            break;

                        case "8":
                            button.ForeColor = System.Drawing.Color.Orange;
                            break;

                    }
                    button.BackColor = System.Drawing.Color.Gray; 
                     
                }  
            }
            if(casillas == 0)
            {
                Fin ganador = new Fin("Ganaste");
                ganador.Show();
                this.Close();
            }
        }


        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            switch (e.Button)
            {
                case MouseButtons.Left:  
                    Destapar(button);
                    break;
                 
            case MouseButtons.Right:
                    bandera(button);
                    break;
            }
        }

        private void bandera(Button button)
        {
            if (button != null && !Convert.ToBoolean(button.Tag))
            {
                if (button.ForeColor ==  System.Drawing.Color.Green )
                {
                    button.ForeColor = System.Drawing.Color.Silver;
                    button.BackColor = System.Drawing.Color.Silver;
                }
                else
                {
                    button.ForeColor = System.Drawing.Color.Green;
                    button.BackColor = System.Drawing.Color.Green;
                }


            }


        }


    }
}
