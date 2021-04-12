
namespace MineSweeper
{
    partial class Menu
    {
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Rb_Personalizado = new System.Windows.Forms.RadioButton();
            this.size = new System.Windows.Forms.TextBox();
            this.minesNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mine Sweeper 3000!";
            // 
            // Bt_Jugar
            // 
            this.Bt_Jugar.Location = new System.Drawing.Point(308, 359);
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
            this.Rb_Principiante.Location = new System.Drawing.Point(209, 147);
            this.Rb_Principiante.Name = "Rb_Principiante";
            this.Rb_Principiante.Size = new System.Drawing.Size(88, 19);
            this.Rb_Principiante.TabIndex = 5;
            this.Rb_Principiante.TabStop = true;
            this.Rb_Principiante.Text = "Principiante";
            this.Rb_Principiante.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(209, 193);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(209, 235);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Rb_Personalizado
            // 
            this.Rb_Personalizado.AutoSize = true;
            this.Rb_Personalizado.Location = new System.Drawing.Point(209, 278);
            this.Rb_Personalizado.Name = "Rb_Personalizado";
            this.Rb_Personalizado.Size = new System.Drawing.Size(98, 19);
            this.Rb_Personalizado.TabIndex = 8;
            this.Rb_Personalizado.TabStop = true;
            this.Rb_Personalizado.Text = "Personalizado";
            this.Rb_Personalizado.UseVisualStyleBackColor = false;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(363, 277);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(108, 23);
            this.size.TabIndex = 9;
            // 
            // minesNumber
            // 
            this.minesNumber.Location = new System.Drawing.Point(503, 277);
            this.minesNumber.Name = "minesNumber";
            this.minesNumber.Size = new System.Drawing.Size(100, 23);
            this.minesNumber.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minesNumber);
            this.Controls.Add(this.size);
            this.Controls.Add(this.Rb_Personalizado);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Rb_Principiante);
            this.Controls.Add(this.Bt_Jugar);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Jugar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton Rb_Personalizado;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox minesNumber;
        private System.Windows.Forms.RadioButton Rb_Principiante;
    }
}