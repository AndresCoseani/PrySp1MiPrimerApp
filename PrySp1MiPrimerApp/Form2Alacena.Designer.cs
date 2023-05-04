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
            this.label1 = new System.Windows.Forms.Label();
            this.Lugar = new System.Windows.Forms.Label();
            this.Alimento = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cantidad2 = new System.Windows.Forms.Label();
            this.Alimento2 = new System.Windows.Forms.Label();
            this.Lugar2 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de alimentos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lugar
            // 
            this.Lugar.AutoSize = true;
            this.Lugar.Location = new System.Drawing.Point(29, 61);
            this.Lugar.Name = "Lugar";
            this.Lugar.Size = new System.Drawing.Size(74, 29);
            this.Lugar.TabIndex = 0;
            this.Lugar.Text = "Lugar";
            this.Lugar.Click += new System.EventHandler(this.label2_Click);
            // 
            // Alimento
            // 
            this.Alimento.AutoSize = true;
            this.Alimento.Location = new System.Drawing.Point(226, 61);
            this.Alimento.Name = "Alimento";
            this.Alimento.Size = new System.Drawing.Size(107, 29);
            this.Alimento.TabIndex = 1;
            this.Alimento.Text = "Alimento";
            this.Alimento.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(426, 61);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(109, 29);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Click += new System.EventHandler(this.label4_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(531, 156);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(97, 24);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.Alimento);
            this.groupBox1.Controls.Add(this.Lugar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacenar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 37);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(231, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 37);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownWidth = 165;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 29;
            this.comboBox3.Location = new System.Drawing.Point(431, 93);
            this.comboBox3.MaxDropDownItems = 20;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(165, 37);
            this.comboBox3.TabIndex = 6;
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(428, 156);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(97, 24);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Cantidad2);
            this.groupBox2.Controls.Add(this.Alimento2);
            this.groupBox2.Controls.Add(this.Lugar2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 186);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Almacenado";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(231, 93);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(165, 37);
            this.comboBox5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-37, -57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Control de alimentos";
            // 
            // Cantidad2
            // 
            this.Cantidad2.AutoSize = true;
            this.Cantidad2.Location = new System.Drawing.Point(426, 61);
            this.Cantidad2.Name = "Cantidad2";
            this.Cantidad2.Size = new System.Drawing.Size(109, 29);
            this.Cantidad2.TabIndex = 2;
            this.Cantidad2.Text = "Cantidad";
            // 
            // Alimento2
            // 
            this.Alimento2.AutoSize = true;
            this.Alimento2.Location = new System.Drawing.Point(226, 61);
            this.Alimento2.Name = "Alimento2";
            this.Alimento2.Size = new System.Drawing.Size(107, 29);
            this.Alimento2.TabIndex = 1;
            this.Alimento2.Text = "Alimento";
            // 
            // Lugar2
            // 
            this.Lugar2.AutoSize = true;
            this.Lugar2.Location = new System.Drawing.Point(29, 61);
            this.Lugar2.Name = "Lugar2";
            this.Lugar2.Size = new System.Drawing.Size(74, 29);
            this.Lugar2.TabIndex = 0;
            this.Lugar2.Text = "Lugar";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(34, 93);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(165, 37);
            this.comboBox6.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2Alacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2Alacena";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2Alacena_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lugar;
        private System.Windows.Forms.Label Alimento;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Cantidad2;
        private System.Windows.Forms.Label Alimento2;
        private System.Windows.Forms.Label Lugar2;
        private System.Windows.Forms.Button button1;
    }
}