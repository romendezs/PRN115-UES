namespace MS24030_Guia3_Ej8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDado1 = new System.Windows.Forms.TextBox();
            this.txtDado2 = new System.Windows.Forms.TextBox();
            this.txtDado3 = new System.Windows.Forms.TextBox();
            this.btnTirar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dado 3";
            // 
            // txtDado1
            // 
            this.txtDado1.Enabled = false;
            this.txtDado1.Location = new System.Drawing.Point(58, 72);
            this.txtDado1.Name = "txtDado1";
            this.txtDado1.Size = new System.Drawing.Size(48, 22);
            this.txtDado1.TabIndex = 3;
            // 
            // txtDado2
            // 
            this.txtDado2.Enabled = false;
            this.txtDado2.Location = new System.Drawing.Point(192, 72);
            this.txtDado2.Name = "txtDado2";
            this.txtDado2.Size = new System.Drawing.Size(48, 22);
            this.txtDado2.TabIndex = 4;
            // 
            // txtDado3
            // 
            this.txtDado3.Enabled = false;
            this.txtDado3.Location = new System.Drawing.Point(330, 75);
            this.txtDado3.Name = "txtDado3";
            this.txtDado3.Size = new System.Drawing.Size(48, 22);
            this.txtDado3.TabIndex = 5;
            // 
            // btnTirar
            // 
            this.btnTirar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTirar.Location = new System.Drawing.Point(474, 42);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(127, 30);
            this.btnTirar.TabIndex = 6;
            this.btnTirar.Text = "Tirar dados";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(474, 81);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 30);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(127, 126);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 16);
            this.lblResults.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 181);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.txtDado3);
            this.Controls.Add(this.txtDado2);
            this.Controls.Add(this.txtDado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDado1;
        private System.Windows.Forms.TextBox txtDado2;
        private System.Windows.Forms.TextBox txtDado3;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResults;
    }
}

