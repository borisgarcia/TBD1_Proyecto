namespace TBD1
{
    partial class FrmPago
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
            this.tabModificar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumPres = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtParamMod2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParamMod = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarMod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumPres2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarMod = new System.Windows.Forms.Button();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtParamBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtParamEliminar2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtParamEliminar = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tabModificar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabEliminar.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.tabPage1);
            this.tabModificar.Controls.Add(this.tabPage2);
            this.tabModificar.Controls.Add(this.tabBuscar);
            this.tabModificar.Controls.Add(this.tabEliminar);
            this.tabModificar.Location = new System.Drawing.Point(3, 2);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.SelectedIndex = 0;
            this.tabModificar.Size = new System.Drawing.Size(425, 281);
            this.tabModificar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabModificar.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(163, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nuevo Pago";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumPres);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 96);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtNumPres
            // 
            this.txtNumPres.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNumPres.Location = new System.Drawing.Point(150, 40);
            this.txtNumPres.Mask = "0000000000";
            this.txtNumPres.Name = "txtNumPres";
            this.txtNumPres.Size = new System.Drawing.Size(66, 20);
            this.txtNumPres.TabIndex = 32;
            this.txtNumPres.ValidatingType = typeof(int);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(311, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Prestamo";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(417, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Modificar Pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtParamMod2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtParamMod);
            this.groupBox3.Controls.Add(this.btnBuscarMod);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(5, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 110);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // txtParamMod2
            // 
            this.txtParamMod2.BackColor = System.Drawing.Color.GhostWhite;
            this.txtParamMod2.Location = new System.Drawing.Point(195, 75);
            this.txtParamMod2.Mask = "0000000000";
            this.txtParamMod2.Name = "txtParamMod2";
            this.txtParamMod2.Size = new System.Drawing.Size(67, 20);
            this.txtParamMod2.TabIndex = 38;
            this.txtParamMod2.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Numero Prestamo";
            // 
            // txtParamMod
            // 
            this.txtParamMod.BackColor = System.Drawing.Color.GhostWhite;
            this.txtParamMod.Location = new System.Drawing.Point(195, 37);
            this.txtParamMod.Mask = "0000000000";
            this.txtParamMod.Name = "txtParamMod";
            this.txtParamMod.Size = new System.Drawing.Size(67, 20);
            this.txtParamMod.TabIndex = 31;
            this.txtParamMod.ValidatingType = typeof(int);
            // 
            // btnBuscarMod
            // 
            this.btnBuscarMod.Location = new System.Drawing.Point(303, 53);
            this.btnBuscarMod.Name = "btnBuscarMod";
            this.btnBuscarMod.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMod.TabIndex = 24;
            this.btnBuscarMod.Text = "Buscar";
            this.btnBuscarMod.UseVisualStyleBackColor = true;
            this.btnBuscarMod.Click += new System.EventHandler(this.btnBuscarMod_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese el Numero Pago";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumPres2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnGuardarMod);
            this.groupBox2.Location = new System.Drawing.Point(3, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 63);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txtNumPres2
            // 
            this.txtNumPres2.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNumPres2.Enabled = false;
            this.txtNumPres2.Location = new System.Drawing.Point(197, 33);
            this.txtNumPres2.Mask = "0000000000";
            this.txtNumPres2.Name = "txtNumPres2";
            this.txtNumPres2.Size = new System.Drawing.Size(67, 20);
            this.txtNumPres2.TabIndex = 32;
            this.txtNumPres2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Numero Prestamo";
            // 
            // btnGuardarMod
            // 
            this.btnGuardarMod.Enabled = false;
            this.btnGuardarMod.Location = new System.Drawing.Point(305, 31);
            this.btnGuardarMod.Name = "btnGuardarMod";
            this.btnGuardarMod.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMod.TabIndex = 22;
            this.btnGuardarMod.Text = "Guardar";
            this.btnGuardarMod.UseVisualStyleBackColor = true;
            this.btnGuardarMod.Click += new System.EventHandler(this.btnGuardarMod_Click);
            // 
            // tabBuscar
            // 
            this.tabBuscar.Controls.Add(this.groupBox8);
            this.tabBuscar.Controls.Add(this.dataGridView1);
            this.tabBuscar.Controls.Add(this.label32);
            this.tabBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(417, 255);
            this.tabBuscar.TabIndex = 2;
            this.tabBuscar.Text = "Buscar";
            this.tabBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtParamBuscar);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.btnBuscar);
            this.groupBox8.Location = new System.Drawing.Point(10, 41);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(398, 67);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            // 
            // txtParamBuscar
            // 
            this.txtParamBuscar.BackColor = System.Drawing.Color.GhostWhite;
            this.txtParamBuscar.Location = new System.Drawing.Point(116, 25);
            this.txtParamBuscar.Mask = "0000000000";
            this.txtParamBuscar.Name = "txtParamBuscar";
            this.txtParamBuscar.Size = new System.Drawing.Size(114, 20);
            this.txtParamBuscar.TabIndex = 32;
            this.txtParamBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParamBuscar.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Buscar Pago";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(295, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(398, 113);
            this.dataGridView1.TabIndex = 37;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(163, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(90, 18);
            this.label32.TabIndex = 36;
            this.label32.Text = "Buscar Pago";
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.label33);
            this.tabEliminar.Controls.Add(this.groupBox9);
            this.tabEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(417, 255);
            this.tabEliminar.TabIndex = 3;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(142, 25);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 18);
            this.label33.TabIndex = 38;
            this.label33.Text = "Eliminar Pago";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtParamEliminar2);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.txtParamEliminar);
            this.groupBox9.Controls.Add(this.btnEliminar);
            this.groupBox9.Location = new System.Drawing.Point(12, 66);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(393, 90);
            this.groupBox9.TabIndex = 37;
            this.groupBox9.TabStop = false;
            // 
            // txtParamEliminar2
            // 
            this.txtParamEliminar2.BackColor = System.Drawing.Color.GhostWhite;
            this.txtParamEliminar2.Location = new System.Drawing.Point(204, 58);
            this.txtParamEliminar2.Mask = "0000000000";
            this.txtParamEliminar2.Name = "txtParamEliminar2";
            this.txtParamEliminar2.Size = new System.Drawing.Size(67, 20);
            this.txtParamEliminar2.TabIndex = 38;
            this.txtParamEliminar2.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = "Numero Pago";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(0, 60);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(198, 18);
            this.label34.TabIndex = 9;
            this.label34.Text = "Ingrese el Numero Prestamo";
            // 
            // txtParamEliminar
            // 
            this.txtParamEliminar.BackColor = System.Drawing.Color.GhostWhite;
            this.txtParamEliminar.Location = new System.Drawing.Point(204, 23);
            this.txtParamEliminar.Mask = "0000000000";
            this.txtParamEliminar.Name = "txtParamEliminar";
            this.txtParamEliminar.Size = new System.Drawing.Size(67, 20);
            this.txtParamEliminar.TabIndex = 32;
            this.txtParamEliminar.ValidatingType = typeof(int);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(299, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(78, 294);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 18);
            this.lblUser.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuario";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(340, 289);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 31;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 320);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.tabModificar);
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            this.tabModificar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabEliminar.ResumeLayout(false);
            this.tabEliminar.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabModificar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtNumPres;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtParamMod;
        private System.Windows.Forms.Button btnBuscarMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardarMod;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.MaskedTextBox txtParamBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.MaskedTextBox txtParamEliminar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtParamEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label34;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNumPres2;
        private System.Windows.Forms.MaskedTextBox txtParamMod2;
        private System.Windows.Forms.Label label4;
    }
}