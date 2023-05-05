namespace PrySp1MiPrimerApp
{
    partial class Form1GestionDeGastos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.mrcGastosVarios = new System.Windows.Forms.GroupBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.mrcIngreso.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.Controls.Add(this.txtDeposito);
            this.mrcIngreso.Controls.Add(this.lblDeposito);
            this.mrcIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngreso.Location = new System.Drawing.Point(20, 34);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(461, 116);
            this.mrcIngreso.TabIndex = 1;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Text = "Ingreso";
            this.mrcIngreso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(163, 48);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(261, 38);
            this.txtDeposito.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(27, 48);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(110, 29);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito";
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.Controls.Add(this.txtComida);
            this.mrcGastosFijos.Controls.Add(this.txtImpuesto);
            this.mrcGastosFijos.Controls.Add(this.txtAlquiler);
            this.mrcGastosFijos.Controls.Add(this.lblAlquiler);
            this.mrcGastosFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijos.Controls.Add(this.lblComida);
            this.mrcGastosFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijos.Location = new System.Drawing.Point(20, 172);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(443, 171);
            this.mrcGastosFijos.TabIndex = 2;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "Gastos fijos";
            this.mrcGastosFijos.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(163, 129);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(261, 36);
            this.txtComida.TabIndex = 5;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(163, 84);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(261, 36);
            this.txtImpuesto.TabIndex = 4;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(163, 35);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(261, 36);
            this.txtAlquiler.TabIndex = 2;
            this.txtAlquiler.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(27, 44);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(95, 29);
            this.lblAlquiler.TabIndex = 3;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(27, 84);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(124, 29);
            this.lblImpuestos.TabIndex = 2;
            this.lblImpuestos.Text = "Impuestos";
            this.lblImpuestos.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(27, 125);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(97, 29);
            this.lblComida.TabIndex = 1;
            this.lblComida.Text = "Comida";
            this.lblComida.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(176, 67);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(261, 30);
            this.txtMonto.TabIndex = 6;
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.Controls.Add(this.txtMonto);
            this.mrcGastosVarios.Controls.Add(this.lblMonto);
            this.mrcGastosVarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVarios.Location = new System.Drawing.Point(20, 376);
            this.mrcGastosVarios.Name = "mrcGastosVarios";
            this.mrcGastosVarios.Size = new System.Drawing.Size(443, 137);
            this.mrcGastosVarios.TabIndex = 3;
            this.mrcGastosVarios.TabStop = false;
            this.mrcGastosVarios.Text = "Gastos varios";
            this.mrcGastosVarios.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(27, 67);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(80, 29);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(358, 628);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(86, 39);
            this.cmdCalcular.TabIndex = 4;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 632);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(71, 567);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.Total_Click);
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTotal.Location = new System.Drawing.Point(216, 567);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(122, 25);
            this.lblResultadoTotal.TabIndex = 7;
            this.lblResultadoTotal.Text = "__________";
            // 
            // Form1GestionDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 679);
            this.Controls.Add(this.lblResultadoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.mrcGastosVarios);
            this.Controls.Add(this.mrcGastosFijos);
            this.Controls.Add(this.mrcIngreso);
            this.Name = "Form1GestionDeGastos";
            this.Text = "GestionDeGastos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.GroupBox mrcGastosVarios;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblResultadoTotal;
    }
}

