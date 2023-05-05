namespace PrySp1MiPrimerApp
{
    partial class Form2Alacena
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
            this.lblControlDeAlimentos = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mrcGuardar = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.cboLugar = new System.Windows.Forms.ComboBox();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.dtpFechaDeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.chkVencimiento = new System.Windows.Forms.CheckBox();
            this.mrcmarco2 = new System.Windows.Forms.GroupBox();
            this.lstProductosIngresados = new System.Windows.Forms.ListBox();
            this.mrcGuardar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.mrcmarco2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblControlDeAlimentos
            // 
            this.lblControlDeAlimentos.AutoSize = true;
            this.lblControlDeAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlDeAlimentos.Location = new System.Drawing.Point(3, 9);
            this.lblControlDeAlimentos.Name = "lblControlDeAlimentos";
            this.lblControlDeAlimentos.Size = new System.Drawing.Size(262, 31);
            this.lblControlDeAlimentos.TabIndex = 0;
            this.lblControlDeAlimentos.Text = "Control de alimentos";
            this.lblControlDeAlimentos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(29, 61);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(74, 29);
            this.lblLugar.TabIndex = 0;
            this.lblLugar.Text = "Lugar";
            this.lblLugar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(226, 61);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(122, 29);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Productos";
            this.lblProducto.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(426, 61);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 29);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(531, 176);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(97, 24);
            this.cmdGuardar.TabIndex = 3;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-37, -57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Control de alimentos";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // mrcGuardar
            // 
            this.mrcGuardar.Controls.Add(this.nudCantidad);
            this.mrcGuardar.Controls.Add(this.cmdCancelar);
            this.mrcGuardar.Controls.Add(this.cboProductos);
            this.mrcGuardar.Controls.Add(this.cboLugar);
            this.mrcGuardar.Controls.Add(this.label5);
            this.mrcGuardar.Controls.Add(this.cmdGuardar);
            this.mrcGuardar.Controls.Add(this.lblCantidad);
            this.mrcGuardar.Controls.Add(this.lblProducto);
            this.mrcGuardar.Controls.Add(this.lblLugar);
            this.mrcGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGuardar.Location = new System.Drawing.Point(22, 53);
            this.mrcGuardar.Name = "mrcGuardar";
            this.mrcGuardar.Size = new System.Drawing.Size(659, 217);
            this.mrcGuardar.TabIndex = 1;
            this.mrcGuardar.TabStop = false;
            this.mrcGuardar.Text = "Guardar";
            this.mrcGuardar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(431, 93);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 30);
            this.nudCantidad.TabIndex = 8;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(413, 176);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(97, 24);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Items.AddRange(new object[] {
            "Galletas",
            "Carne",
            "Pastas",
            "Huevos",
            "Detergente"});
            this.cboProductos.Location = new System.Drawing.Point(231, 93);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(165, 28);
            this.cboProductos.TabIndex = 5;
            // 
            // cboLugar
            // 
            this.cboLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLugar.FormattingEnabled = true;
            this.cboLugar.Items.AddRange(new object[] {
            "Heladera",
            "Freezer",
            "Alacena"});
            this.cboLugar.Location = new System.Drawing.Point(34, 93);
            this.cboLugar.Name = "cboLugar";
            this.cboLugar.Size = new System.Drawing.Size(165, 28);
            this.cboLugar.TabIndex = 4;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Location = new System.Drawing.Point(575, 569);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCerrar.TabIndex = 9;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // dtpFechaDeVencimiento
            // 
            this.dtpFechaDeVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeVencimiento.Location = new System.Drawing.Point(266, 65);
            this.dtpFechaDeVencimiento.Name = "dtpFechaDeVencimiento";
            this.dtpFechaDeVencimiento.Size = new System.Drawing.Size(244, 23);
            this.dtpFechaDeVencimiento.TabIndex = 6;
            // 
            // chkVencimiento
            // 
            this.chkVencimiento.AutoSize = true;
            this.chkVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVencimiento.Location = new System.Drawing.Point(88, 59);
            this.chkVencimiento.Name = "chkVencimiento";
            this.chkVencimiento.Size = new System.Drawing.Size(111, 29);
            this.chkVencimiento.TabIndex = 8;
            this.chkVencimiento.Text = "¿Vence?";
            this.chkVencimiento.UseVisualStyleBackColor = true;
            this.chkVencimiento.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mrcmarco2
            // 
            this.mrcmarco2.Controls.Add(this.dtpFechaDeVencimiento);
            this.mrcmarco2.Controls.Add(this.chkVencimiento);
            this.mrcmarco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcmarco2.Location = new System.Drawing.Point(22, 318);
            this.mrcmarco2.Name = "mrcmarco2";
            this.mrcmarco2.Size = new System.Drawing.Size(659, 133);
            this.mrcmarco2.TabIndex = 10;
            this.mrcmarco2.TabStop = false;
            this.mrcmarco2.Text = "Fecha de Vencimiento";
            // 
            // lstProductosIngresados
            // 
            this.lstProductosIngresados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductosIngresados.FormattingEnabled = true;
            this.lstProductosIngresados.ItemHeight = 25;
            this.lstProductosIngresados.Location = new System.Drawing.Point(22, 483);
            this.lstProductosIngresados.Name = "lstProductosIngresados";
            this.lstProductosIngresados.Size = new System.Drawing.Size(659, 54);
            this.lstProductosIngresados.TabIndex = 11;
            this.lstProductosIngresados.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Form2Alacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 604);
            this.Controls.Add(this.lstProductosIngresados);
            this.Controls.Add(this.mrcmarco2);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.mrcGuardar);
            this.Controls.Add(this.lblControlDeAlimentos);
            this.Name = "Form2Alacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.Form2Alacena_Load);
            this.mrcGuardar.ResumeLayout(false);
            this.mrcGuardar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.mrcmarco2.ResumeLayout(false);
            this.mrcmarco2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlDeAlimentos;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox mrcGuardar;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.ComboBox cboLugar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.CheckBox chkVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaDeVencimiento;
        private System.Windows.Forms.GroupBox mrcmarco2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ListBox lstProductosIngresados;
    }
}