namespace PRN115_Ejercicio
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
            label1 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            txtNombreCliente = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMarca = new TextBox();
            btnFacturar = new Button();
            lblFactura = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 67);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 163);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de Garrafones";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(66, 186);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(318, 27);
            txtCantidad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 234);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(66, 257);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(318, 27);
            txtNombreCliente.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 87);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "1) Alpina";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 107);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 7;
            label5.Text = "2) Alpina";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(208, 100);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 27);
            txtMarca.TabIndex = 8;
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(185, 314);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(94, 29);
            btnFacturar.TabIndex = 9;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Location = new Point(66, 380);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(0, 20);
            lblFactura.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 465);
            Controls.Add(lblFactura);
            Controls.Add(btnFacturar);
            Controls.Add(txtMarca);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNombreCliente);
            Controls.Add(label3);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private TextBox txtNombreCliente;
        private Label label4;
        private Label label5;
        private TextBox txtMarca;
        private Button btnFacturar;
        private Label lblFactura;
    }
}
