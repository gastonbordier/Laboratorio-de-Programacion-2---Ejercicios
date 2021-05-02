
namespace Ejercicio23
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnDolar = new System.Windows.Forms.Button();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pesos";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(143, 119);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolar.TabIndex = 4;
            this.txtDolar.Leave += new System.EventHandler(this.txtDolar_Leave);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(143, 164);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuro.TabIndex = 5;
            this.txtEuro.Leave += new System.EventHandler(this.txtEuro_Leave);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(143, 210);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // btnDolar
            // 
            this.btnDolar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDolar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDolar.Location = new System.Drawing.Point(274, 114);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(94, 33);
            this.btnDolar.TabIndex = 7;
            this.btnDolar.Text = "->";
            this.btnDolar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(395, 208);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.ReadOnly = true;
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 23);
            this.txtPesoADolar.TabIndex = 12;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(395, 162);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.ReadOnly = true;
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 23);
            this.txtEuroADolar.TabIndex = 11;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(395, 117);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 23);
            this.txtDolarADolar.TabIndex = 10;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(518, 208);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.ReadOnly = true;
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtPesoAEuro.TabIndex = 15;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(518, 162);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.ReadOnly = true;
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtEuroAEuro.TabIndex = 14;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(518, 117);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.ReadOnly = true;
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 23);
            this.txtDolarAEuro.TabIndex = 13;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Location = new System.Drawing.Point(638, 208);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.ReadOnly = true;
            this.txtPesosAPesos.Size = new System.Drawing.Size(100, 23);
            this.txtPesosAPesos.TabIndex = 18;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(638, 162);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.ReadOnly = true;
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtEuroAPeso.TabIndex = 17;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(638, 117);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.ReadOnly = true;
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 23);
            this.txtDolarAPeso.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(395, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dolar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(518, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Euro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(638, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pesos";
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(638, 42);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionPeso.TabIndex = 24;
            this.txtCotizacionPeso.Leave += new System.EventHandler(this.txtCotizacionPeso_Leave);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(518, 42);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionEuro.TabIndex = 23;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(395, 42);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 23);
            this.txtCotizacionDolar.TabIndex = 22;
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBloquear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBloquear.Location = new System.Drawing.Point(274, 37);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(94, 32);
            this.btnBloquear.TabIndex = 25;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // btnEuro
            // 
            this.btnEuro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEuro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEuro.Location = new System.Drawing.Point(274, 157);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(94, 33);
            this.btnEuro.TabIndex = 26;
            this.btnEuro.Text = "->";
            this.btnEuro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPeso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPeso.Location = new System.Drawing.Point(274, 203);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(94, 33);
            this.btnPeso.TabIndex = 27;
            this.btnPeso.Text = "->";
            this.btnPeso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnBloquear);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloquear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnPeso;
    }
}

