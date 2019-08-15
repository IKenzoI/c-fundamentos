namespace WindowsFormsApp2
{
    partial class PesoIdeal
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
            this.checkBoxMulher = new System.Windows.Forms.CheckBox();
            this.checkBoxHomem = new System.Windows.Forms.CheckBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura:";
            // 
            // checkBoxMulher
            // 
            this.checkBoxMulher.AutoSize = true;
            this.checkBoxMulher.Location = new System.Drawing.Point(192, 60);
            this.checkBoxMulher.Name = "checkBoxMulher";
            this.checkBoxMulher.Size = new System.Drawing.Size(58, 17);
            this.checkBoxMulher.TabIndex = 3;
            this.checkBoxMulher.Text = "Mulher";
            this.checkBoxMulher.UseVisualStyleBackColor = true;
            // 
            // checkBoxHomem
            // 
            this.checkBoxHomem.AutoSize = true;
            this.checkBoxHomem.Location = new System.Drawing.Point(124, 60);
            this.checkBoxHomem.Name = "checkBoxHomem";
            this.checkBoxHomem.Size = new System.Drawing.Size(62, 17);
            this.checkBoxHomem.TabIndex = 4;
            this.checkBoxHomem.Text = "Homem";
            this.checkBoxHomem.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(163, 26);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(124, 93);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Peso ideal";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // PesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.checkBoxHomem);
            this.Controls.Add(this.checkBoxMulher);
            this.Controls.Add(this.label1);
            this.Name = "PesoIdeal";
            this.Text = "PesoIdeal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMulher;
        private System.Windows.Forms.CheckBox checkBoxHomem;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
    }
}