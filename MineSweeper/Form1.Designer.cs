using System.Windows.Forms;
namespace MineSweeper

{
    partial class Form1
    {
        int column, row, mines;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        public Form1(int row, int column, int mines)
        {
            this.row = row;
            this.column = column;
            this.mines = mines;
            this.InitializeComponent();
            this.GenerateTable(column, row);
        }
        private void setNumbers(MatrizEnTripleta mat)
        {
            for (int i = 1; i < mat.retornaNumeroTripletas(); i++)
            {
                Tripleta tp = mat.retornaTripleta(i);
                int fila = tp.retornaFila();
                int columna = tp.retornaColumna();
                for (int j = -1; j <= 1; i++)
                {
                    for (int k = -1; k <= 1; k++)
                    {
                        fila += i;
                        columna += j;
                        if (k == 0 && j == 0) { continue; }
                        if (fila >= 0 && fila <= mat.retornaNumeroFilas() && columna >= 0 && columna <= mat.retornaNumeroColumnas())
                        {
                            try
                            {
                                int valor = int.Parse(this.tableLayoutPanel1.GetControlFromPosition(columna, fila).Text);
                                valor += 1;
                                this.tableLayoutPanel1.GetControlFromPosition(columna, fila).Text = string.Format("{0}", valor);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }
                }
            }
        }
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(31, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 344);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 344);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Juego";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void GenerateTable(int columnCount, int rowCount)
        {
            //Clear out the existing controls, we are generating a new table layout
            tableLayoutPanel1.Controls.Clear();

            //Clear out the existing row and column styles
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    if (x == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    //Create the control, in this case we will add a button
                    Button cmd = new Button();
                    cmd.Text = string.Format("({0}, {1})", x, y);         //Finally, add the control to the correct location in the table
                    tableLayoutPanel1.Controls.Add(cmd, x, y);
                }

            }
            
            MatrizEnTripleta mat = new MatrizEnTripleta(new Tripleta(row, column, 0));
           mat.generarMinas(this.mines);
             
           for (int i = 1; i <= mines; i++)
            {
                Button cmds = new Button();
                cmds.Text = string.Format("minita");
                tableLayoutPanel1.Controls.Add(cmds, mat.retornaTripleta(i).retornaFila(), mat.retornaTripleta(i).retornaColumna());
            }

        }


        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}