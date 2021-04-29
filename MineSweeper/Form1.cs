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

        /*en este método se destapa una celda. Hay tres posibilidades:
         1-La celda es una mina: Game over, finaliza la ejecución del programa principal.
         2-La celda NO es aledaña a una mina: se ejecuta recursivamente el método Destapar() con las celdas vecinas.
         3-La celda es aledaña a una mina o más: en cuyo caso solamente se muestra el valor celda clickeada es decir 
            número.
         */

        private void Destapar(Button button)
        {


            if (button != null&&!Convert.ToBoolean(button.Tag))
            {
                button.Tag = true;
                TableLayoutPanelCellPosition coordenadas = tableLayoutPanel1.GetCellPosition(button);
                //Caso 1, celda que es una mina
                if (button.Text == "X")
                {
                    Fin fin = new Fin("Has detonado una mina.Fin del juego :c");
                    fin.Show();
                    this.Close();
                    button.Text = "💣";
                    button.ForeColor = System.Drawing.Color.Red;
                    button.BackColor = System.Drawing.Color.Gray;
                } 

                //Caso 2, celda que no es aledaña a una mina
                if (button.Text == "0")
                {
                    this.casillasPorDestapar -= 1;
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

                //Caso 3, celda que es aledaña a una mina
                else
                {
                    this.casillasPorDestapar -= 1;

                    //Cada número posible tiene su respectivo color
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
            if(casillasPorDestapar == 0)
            {
                Fin ganador = new Fin("Has limpiado el terreno de minas, felicitaciones, Ganaste :)");
                ganador.Show();
                this.Close();
            }
        }


        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
                    Destapar(button);      
        }



    }
}
