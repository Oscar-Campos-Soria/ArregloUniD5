
namespace ArregloUniD5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncrear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.LBx = new System.Windows.Forms.ListBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(12, 56);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(112, 71);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "Crear Arreglo";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(130, 56);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(137, 71);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Continuar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // LBx
            // 
            this.LBx.FormattingEnabled = true;
            this.LBx.ItemHeight = 15;
            this.LBx.Location = new System.Drawing.Point(342, 9);
            this.LBx.Name = "LBx";
            this.LBx.Size = new System.Drawing.Size(120, 94);
            this.LBx.TabIndex = 3;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(12, 27);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(311, 23);
            this.txtLong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aqui ingresaras los numeros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBx);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.btncrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox LBx;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label1;
    }
}

