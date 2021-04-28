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
        private void Bt_Jugar_Click(object sender, EventArgs e)
        {
            if (Rb_Principiante.Checked)
            {
                this.Visible = false;
                Form1 Juego = new Form1(8,8,10);
                Juego.Show();
                
            }
            else if (Rb_Intermedio.Checked)
            {
                this.Visible = false;
                Form1 Juego = new Form1(16, 16, 40);
                Juego.Show();
            }
            else if (Rb_Experto.Checked)
            {
                this.Visible = false;
                Form1 Juego = new Form1(16, 30, 99);
                Juego.Show();
               
            }
            else if (Rb_Personalizado.Checked)
            {
                int fila = int.Parse(Tb_fila.Text);
                int columna = int.Parse(Tb_columna.Text);
                int minas = int.Parse(Tb_minas.Text);

                if(minas > 0 && minas < columna * fila)
                {
                    this.Visible = false;
                    Form1 Juego = new Form1(columna, fila, minas);
                    Juego.Show();
                }    
                else
                {
                    label2.Text = "Por favor ingresa una cantidad de minas válida.";
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Image bomba = System.Drawing.Image.FromFile("C:\\Users\\axels\\source\\repos\\MineSweeper\\MineSweeper\\Img\\Bomb.png");
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = bomba;
        }
    }
    }

