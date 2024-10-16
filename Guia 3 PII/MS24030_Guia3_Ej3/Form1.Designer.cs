namespace MS24030_Guia3_Ej3
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtGasolinera = new System.Windows.Forms.TextBox();
            this.txtSuper = new System.Windows.Forms.TextBox();
            this.txtRegular = new System.Windows.Forms.TextBox();
            this.txtDiesel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvGasolineras = new System.Windows.Forms.DataGridView();
            this.Gasolinera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Super = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasolineras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Gasolinera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Super";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Regular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Diesel";
            // 
            // txtGasolinera
            // 
            this.txtGasolinera.Location = new System.Drawing.Point(118, 76);
            this.txtGasolinera.Name = "txtGasolinera";
            this.txtGasolinera.Size = new System.Drawing.Size(100, 22);
            this.txtGasolinera.TabIndex = 4;
            // 
            // txtSuper
            // 
            this.txtSuper.Location = new System.Drawing.Point(438, 48);
            this.txtSuper.Name = "txtSuper";
            this.txtSuper.Size = new System.Drawing.Size(100, 22);
            this.txtSuper.TabIndex = 5;
            // 
            // txtRegular
            // 
            this.txtRegular.Location = new System.Drawing.Point(438, 79);
            this.txtRegular.Name = "txtRegular";
            this.txtRegular.Size = new System.Drawing.Size(100, 22);
            this.txtRegular.TabIndex = 6;
            // 
            // txtDiesel
            // 
            this.txtDiesel.Location = new System.Drawing.Point(438, 115);
            this.txtDiesel.Name = "txtDiesel";
            this.txtDiesel.Size = new System.Drawing.Size(100, 22);
            this.txtDiesel.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(86, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(187, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvGasolineras
            // 
            this.dgvGasolineras.AllowUserToAddRows = false;
            this.dgvGasolineras.AllowUserToDeleteRows = false;
            this.dgvGasolineras.AllowUserToResizeColumns = false;
            this.dgvGasolineras.AllowUserToResizeRows = false;
            this.dgvGasolineras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasolineras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gasolinera,
            this.Super,
            this.Regular,
            this.Diesel});
            this.dgvGasolineras.Location = new System.Drawing.Point(39, 169);
            this.dgvGasolineras.Name = "dgvGasolineras";
            this.dgvGasolineras.RowHeadersWidth = 51;
            this.dgvGasolineras.RowTemplate.Height = 24;
            this.dgvGasolineras.Size = new System.Drawing.Size(552, 223);
            this.dgvGasolineras.TabIndex = 10;
            // 
            // Gasolinera
            // 
            this.Gasolinera.HeaderText = "Nombre Gasolinera";
            this.Gasolinera.MinimumWidth = 6;
            this.Gasolinera.Name = "Gasolinera";
            this.Gasolinera.Width = 125;
            // 
            // Super
            // 
            this.Super.HeaderText = "Super";
            this.Super.MinimumWidth = 6;
            this.Super.Name = "Super";
            this.Super.Width = 125;
            // 
            // Regular
            // 
            this.Regular.HeaderText = "Regular";
            this.Regular.MinimumWidth = 6;
            this.Regular.Name = "Regular";
            this.Regular.Width = 125;
            // 
            // Diesel
            // 
            this.Diesel.HeaderText = "Diesel";
            this.Diesel.MinimumWidth = 6;
            this.Diesel.Name = "Diesel";
            this.Diesel.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 431);
            this.Controls.Add(this.dgvGasolineras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDiesel);
            this.Controls.Add(this.txtRegular);
            this.Controls.Add(this.txtSuper);
            this.Controls.Add(this.txtGasolinera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasolineras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGasolinera;
        private System.Windows.Forms.TextBox txtSuper;
        private System.Windows.Forms.TextBox txtRegular;
        private System.Windows.Forms.TextBox txtDiesel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvGasolineras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gasolinera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Super;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diesel;
    }
}

