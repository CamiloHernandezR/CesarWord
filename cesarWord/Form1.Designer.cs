namespace cesarWord
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnCifrar);
            this.panel1.Controls.Add(this.btnArchivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCifrado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(595, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 375);
            this.panel2.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(464, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 34);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.Location = new System.Drawing.Point(71, 30);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(125, 34);
            this.btnArchivo.TabIndex = 1;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // btnCifrar
            // 
            this.btnCifrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCifrar.Location = new System.Drawing.Point(444, 30);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(125, 34);
            this.btnCifrar.TabIndex = 2;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(3, 3);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCadena.Size = new System.Drawing.Size(434, 348);
            this.txtCadena.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtCadena);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 375);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // txtCifrado
            // 
            this.txtCifrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCifrado.Location = new System.Drawing.Point(0, 0);
            this.txtCifrado.Multiline = true;
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCifrado.Size = new System.Drawing.Size(437, 375);
            this.txtCifrado.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtLlave);
            this.panel3.Location = new System.Drawing.Point(615, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 77);
            this.panel3.TabIndex = 4;
            // 
            // txtLlave
            // 
            this.txtLlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLlave.Location = new System.Drawing.Point(0, 0);
            this.txtLlave.Multiline = true;
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLlave.Size = new System.Drawing.Size(417, 77);
            this.txtLlave.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

