namespace MS24030_Guia3_Ej2
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
            this.rbtAcreditar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDebitar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBeneficiado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEfectuar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtAcreditar
            // 
            this.rbtAcreditar.AutoSize = true;
            this.rbtAcreditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAcreditar.Location = new System.Drawing.Point(56, 89);
            this.rbtAcreditar.Name = "rbtAcreditar";
            this.rbtAcreditar.Size = new System.Drawing.Size(103, 26);
            this.rbtAcreditar.TabIndex = 0;
            this.rbtAcreditar.TabStop = true;
            this.rbtAcreditar.Text = "Acreditar";
            this.rbtAcreditar.UseVisualStyleBackColor = true;
            this.rbtAcreditar.Click += new System.EventHandler(this.rbtAcreditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaccion";
            // 
            // rbtDebitar
            // 
            this.rbtDebitar.AutoSize = true;
            this.rbtDebitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDebitar.Location = new System.Drawing.Point(56, 121);
            this.rbtDebitar.Name = "rbtDebitar";
            this.rbtDebitar.Size = new System.Drawing.Size(89, 26);
            this.rbtDebitar.TabIndex = 2;
            this.rbtDebitar.TabStop = true;
            this.rbtDebitar.Text = "Debitar";
            this.rbtDebitar.UseVisualStyleBackColor = true;
            this.rbtDebitar.Click += new System.EventHandler(this.rbtDebitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beneficiado:";
            // 
            // txtBeneficiado
            // 
            this.txtBeneficiado.Location = new System.Drawing.Point(298, 72);
            this.txtBeneficiado.Name = "txtBeneficiado";
            this.txtBeneficiado.Size = new System.Drawing.Size(100, 22);
            this.txtBeneficiado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(298, 121);
            this.nudCantidad.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 22);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaccion,
            this.Beneficiado});
            this.dgvTransacciones.Location = new System.Drawing.Point(56, 226);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.RowHeadersWidth = 51;
            this.dgvTransacciones.RowTemplate.Height = 24;
            this.dgvTransacciones.Size = new System.Drawing.Size(376, 150);
            this.dgvTransacciones.TabIndex = 8;
            // 
            // Transaccion
            // 
            this.Transaccion.HeaderText = "Transaccion";
            this.Transaccion.MinimumWidth = 6;
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.Width = 125;
            // 
            // Beneficiado
            // 
            this.Beneficiado.HeaderText = "Beneficiado";
            this.Beneficiado.MinimumWidth = 6;
            this.Beneficiado.Name = "Beneficiado";
            this.Beneficiado.Width = 200;
            // 
            // btnEfectuar
            // 
            this.btnEfectuar.Location = new System.Drawing.Point(313, 160);
            this.btnEfectuar.Name = "btnEfectuar";
            this.btnEfectuar.Size = new System.Drawing.Size(75, 23);
            this.btnEfectuar.TabIndex = 9;
            this.btnEfectuar.Text = "Efectuar";
            this.btnEfectuar.UseVisualStyleBackColor = true;
            this.btnEfectuar.Click += new System.EventHandler(this.btnEfectuar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(51, 170);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(185, 29);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "Saldo Actual: $0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnEfectuar);
            this.Controls.Add(this.dgvTransacciones);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBeneficiado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtDebitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtAcreditar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtAcreditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtDebitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBeneficiado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiado;
        private System.Windows.Forms.Button btnEfectuar;
        private System.Windows.Forms.Label lblSaldo;
    }
}

