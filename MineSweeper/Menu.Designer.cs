
namespace MineSweeper
{
    partial class Menu
    {
        public Menu()
        {
            this.InitializeComponent();
            
        }
     
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Jugar = new System.Windows.Forms.Button();
            this.Rb_Principiante = new System.Windows.Forms.RadioButton();
            this.Rb_Intermedio = new System.Windows.Forms.RadioButton();
            this.Rb_Experto = new System.Windows.Forms.RadioButton();
            this.Rb_Personalizado = new System.Windows.Forms.RadioButton();
            this.Tb_columna = new System.Windows.Forms.TextBox();
            this.Tb_fila = new System.Windows.Forms.TextBox();
            this.Tb_minas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mine Sweeper 3000!";
            // 
            // Bt_Jugar
            // 
            this.Bt_Jugar.Location = new System.Drawing.Point(100, 275);
            this.Bt_Jugar.Name = "Bt_Jugar";
            this.Bt_Jugar.Size = new System.Drawing.Size(198, 41);
            this.Bt_Jugar.TabIndex = 4;
            this.Bt_Jugar.Text = "Jugar";
            this.Bt_Jugar.UseVisualStyleBackColor = true;
            this.Bt_Jugar.Click += new System.EventHandler(this.Bt_Jugar_Click);
            // 
            // Rb_Principiante
            // 
            this.Rb_Principiante.AutoSize = true;
            this.Rb_Principiante.Location = new System.Drawing.Point(61, 120);
            this.Rb_Principiante.Name = "Rb_Principiante";
            this.Rb_Principiante.Size = new System.Drawing.Size(88, 19);
            this.Rb_Principiante.TabIndex = 5;
            this.Rb_Principiante.TabStop = true;
            this.Rb_Principiante.Text = "Principiante";
            this.Rb_Principiante.UseVisualStyleBackColor = true;
            // 
            // Rb_Intermedio
            // 
            this.Rb_Intermedio.AutoSize = true;
            this.Rb_Intermedio.Location = new System.Drawing.Point(61, 145);
            this.Rb_Intermedio.Name = "Rb_Intermedio";
            this.Rb_Intermedio.Size = new System.Drawing.Size(83, 19);
            this.Rb_Intermedio.TabIndex = 6;
            this.Rb_Intermedio.TabStop = true;
            this.Rb_Intermedio.Text = "Intermedio";
            this.Rb_Intermedio.UseVisualStyleBackColor = true;
            // 
            // Rb_Experto
            // 
            this.Rb_Experto.AutoSize = true;
            this.Rb_Experto.Location = new System.Drawing.Point(61, 170);
            this.Rb_Experto.Name = "Rb_Experto";
            this.Rb_Experto.Size = new System.Drawing.Size(65, 19);
            this.Rb_Experto.TabIndex = 7;
            this.Rb_Experto.TabStop = true;
            this.Rb_Experto.Text = "Experto";
            this.Rb_Experto.UseVisualStyleBackColor = true;
            // 
            // Rb_Personalizado
            // 
            this.Rb_Personalizado.AutoSize = true;
            this.Rb_Personalizado.Location = new System.Drawing.Point(61, 212);
            this.Rb_Personalizado.Name = "Rb_Personalizado";
            this.Rb_Personalizado.Size = new System.Drawing.Size(98, 19);
            this.Rb_Personalizado.TabIndex = 8;
            this.Rb_Personalizado.TabStop = true;
            this.Rb_Personalizado.Text = "Personalizado";
            this.Rb_Personalizado.UseVisualStyleBackColor = false;
            // 
            // Tb_columna
            // 
            this.Tb_columna.Location = new System.Drawing.Point(245, 212);
            this.Tb_columna.Name = "Tb_columna";
            this.Tb_columna.Size = new System.Drawing.Size(45, 23);
            this.Tb_columna.TabIndex = 9;
            // 
            // Tb_fila
            // 
            this.Tb_fila.Location = new System.Drawing.Point(175, 211);
            this.Tb_fila.Name = "Tb_fila";
            this.Tb_fila.Size = new System.Drawing.Size(45, 23);
            this.Tb_fila.TabIndex = 10;
            // 
            // Tb_minas
            // 
            this.Tb_minas.Location = new System.Drawing.Point(310, 212);
            this.Tb_minas.Name = "Tb_minas";
            this.Tb_minas.Size = new System.Drawing.Size(45, 23);
            this.Tb_minas.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "8 x 8 , 10 minas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "16 x 16, 40 minas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "16 x 30, 99 minas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "x";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(391, 342);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_minas);
            this.Controls.Add(this.Tb_fila);
            this.Controls.Add(this.Tb_columna);
            this.Controls.Add(this.Rb_Personalizado);
            this.Controls.Add(this.Rb_Experto);
            this.Controls.Add(this.Rb_Intermedio);
            this.Controls.Add(this.Rb_Principiante);
            this.Controls.Add(this.Bt_Jugar);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Jugar;
        private System.Windows.Forms.RadioButton Rb_Intermedio;
        private System.Windows.Forms.RadioButton Rb_Experto;
        private System.Windows.Forms.RadioButton Rb_Personalizado;
        private System.Windows.Forms.TextBox Tb_columna;
        private System.Windows.Forms.TextBox Tb_fila;
        private System.Windows.Forms.RadioButton Rb_Principiante;
        private System.Windows.Forms.TextBox Tb_minas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}