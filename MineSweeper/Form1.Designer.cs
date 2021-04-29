using System.Windows.Forms;
using System.Drawing;
namespace MineSweeper

{
    partial class Form1
    {
        /*
         * Tener en cuenta lo siguiente:
         * - las minas se representan como una X
         * - casillas a destapar se defina como : (filas * columnas) - (casillas previamente destapadas)
         * -  El Programa principal finaliza cuando:
         *      a. casillasPorDestar = 0
         *      b. se destapa una mina y por tanto casillasPorDestapar > 0
         */
        int numeroColumnas, numeroFilas, numeroDeMinas, casillasPorDestapar;
      
        MatrizEnTripleta matrizBombas;

        /*Este constructor realiza lo siguiente:
          - crea un tablelayout del tamaño filas,columnas
          - genera n numero de coordenadas aleatorias que seran almacenadas en una matriz dispersa
          - asigna el número correspondiente a las celdas aledañas a minas
          - genera la tabla donde graficamente se podra jugar
         */
        public Form1(int numeroFilas, int numeroColumnas, int numeroDeMinas)
        {
            this.numeroFilas = numeroFilas;
            this.numeroColumnas = numeroColumnas;
            this.numeroDeMinas = numeroDeMinas;
            this.casillasPorDestapar = numeroFilas * numeroColumnas - numeroDeMinas;
            this.matrizBombas = new MatrizEnTripleta(new Tripleta(numeroFilas, numeroColumnas, 0));
            this.matrizBombas.generarCoordenadasAleatorias(numeroDeMinas);
            this.InitializeComponent();
            this.GenerarTabla(numeroColumnas, numeroFilas);
            this.Minar();
            this.AsignarNumeros();
        }

        private Button GenerarBoton()
        {
            Button cmd = new Button();
            cmd.Size = new System.Drawing.Size(30, 30);
            cmd.Tag = false;
            cmd.ForeColor = System.Drawing.Color.Silver;
            cmd.BackColor = System.Drawing.Color.Silver;
            cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            cmd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            cmd.Text = "0";
            return cmd;
        }


        //método que asigna los números que van al rededor de las minas 
        private void AsignarNumeros()
        {
            int fila, columna;
            for (int i = 1; i <= this.numeroDeMinas; i++)
            {
                //En el ciclo anidado siguiente se recorre todas las posibles combinaciones de ((x+i),(y+j))
                //que son las celdas circundantes a minas y se les asigna un valor =+1
                for (int j = -1; j <= 1; j++)
                {
                    for (int k = -1; k <= 1; k++)
                    {
                        //la cuenta en el tablelayout empieza desde 0, por eso se resta una unidad
                        fila = matrizBombas.retornaTripleta(i).retornaFila() - 1;
                        columna = matrizBombas.retornaTripleta(i).retornaColumna() - 1;

                        //la unica excepción posible se da en los bordes de la matriz al intentar acceder a posiciones menores a 
                        //0 ó mayores al número de columnas o filas, esto se controla con este try-catch
                        try
                        {
                            // Recordar que "X" es la forma de representar las minas, por tanto a la celda se le suma una
                            //unidad solo si el valor del texto del boton es diferente de 0

                            Control control = tableLayoutPanel1.GetControlFromPosition(columna + j, fila + k);
                            if (control != null && tableLayoutPanel1.GetControlFromPosition(columna + j, fila + k).Text != "X")
                            {
                                int numeroActual = int.Parse(tableLayoutPanel1.GetControlFromPosition(columna + j, fila + k).Text) + 1;
                                tableLayoutPanel1.GetControlFromPosition(columna + j, fila + k).Text = numeroActual.ToString();
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
        }


        /*Asocia cada elemento de la matriz dispersa con una coordenada del tablelayout
        Usamos el simbolo "X" para representar las minas.*/
        public void Minar()
        {
            for (int i = 1; i <= this.matrizBombas.retornaNumeroTripletas(); i++)
            {
                tableLayoutPanel1.GetControlFromPosition(this.matrizBombas.retornaTripleta(i).retornaColumna() - 1, this.matrizBombas.retornaTripleta(i).retornaFila() - 1).Text = "X";
            }
        }

        //genera la tabla donde se juega graficamente
        private void GenerarTabla(int columnCount, int rowCount)
        {
            //se limpia el tablelayout que se crea inicialmente con la tabla
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            //se establece el número de filas y columnas de acuerdo al tamaño que se haya establecido
            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;
            tableLayoutPanel1.AutoScroll = true;

            //Se inserta un boton en las coordenadas deseada
            for (int x = 0; x < columnCount; x++)
            {
                for (int y = 0; y < rowCount; y++)
                {
                    Button cmd = GenerarBoton();
                    tableLayoutPanel1.Controls.Add(cmd, x, y);
                }
            }
        }



        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
      
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 336);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }

}   
