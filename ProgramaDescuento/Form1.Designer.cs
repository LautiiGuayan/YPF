namespace ProgramaDescuento
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BARRA1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LBL1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.LBL3 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.BTNACCEDER = new System.Windows.Forms.Button();
            this.comprar = new System.Windows.Forms.Button();
            this.NUMERO1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.VOLVER = new System.Windows.Forms.Button();
            this.vercompra = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnafta = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.lblgnc = new System.Windows.Forms.Label();
            this.lblaceite = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUMERO1)).BeginInit();
            this.SuspendLayout();
            // 
            // BARRA1
            // 
            this.BARRA1.BackColor = System.Drawing.Color.Cyan;
            this.BARRA1.ForeColor = System.Drawing.Color.Aqua;
            this.BARRA1.Location = new System.Drawing.Point(18, 150);
            this.BARRA1.Name = "BARRA1";
            this.BARRA1.Size = new System.Drawing.Size(236, 33);
            this.BARRA1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido A YPF!";
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.Black;
            this.B1.Location = new System.Drawing.Point(66, 83);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(136, 40);
            this.B1.TabIndex = 2;
            this.B1.Text = "INICIAR";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.BackColor = System.Drawing.Color.Transparent;
            this.LBL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.ForeColor = System.Drawing.Color.Cyan;
            this.LBL1.Location = new System.Drawing.Point(391, 66);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(319, 24);
            this.LBL1.TabIndex = 5;
            this.LBL1.Text = "Crear Cuenta De Usuario De YPF";
            this.LBL1.Visible = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(432, 117);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(234, 33);
            this.txtusuario.TabIndex = 6;
            this.txtusuario.Visible = false;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(432, 189);
            this.txtcontraseña.Multiline = true;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(234, 33);
            this.txtcontraseña.TabIndex = 7;
            this.txtcontraseña.Visible = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(432, 258);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(111, 59);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "CREAR CUENTA";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.BackColor = System.Drawing.Color.Transparent;
            this.LBL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL3.ForeColor = System.Drawing.Color.Cyan;
            this.LBL3.Location = new System.Drawing.Point(204, 117);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(206, 24);
            this.LBL3.TabIndex = 9;
            this.LBL3.Text = "Nombre De Usuario :";
            this.LBL3.Visible = false;
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.BackColor = System.Drawing.Color.Transparent;
            this.LBL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2.ForeColor = System.Drawing.Color.Cyan;
            this.LBL2.Location = new System.Drawing.Point(288, 198);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(122, 24);
            this.LBL2.TabIndex = 10;
            this.LBL2.Text = "Contraseña:";
            this.LBL2.Visible = false;
            // 
            // BTNACCEDER
            // 
            this.BTNACCEDER.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACCEDER.Location = new System.Drawing.Point(555, 258);
            this.BTNACCEDER.Name = "BTNACCEDER";
            this.BTNACCEDER.Size = new System.Drawing.Size(111, 59);
            this.BTNACCEDER.TabIndex = 11;
            this.BTNACCEDER.Text = "INICIAR SECCION";
            this.BTNACCEDER.UseVisualStyleBackColor = true;
            this.BTNACCEDER.Visible = false;
            this.BTNACCEDER.Click += new System.EventHandler(this.BTNACCEDER_Click);
            // 
            // comprar
            // 
            this.comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprar.Location = new System.Drawing.Point(959, 261);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(120, 34);
            this.comprar.TabIndex = 14;
            this.comprar.Text = "COMPRAR";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Visible = false;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // NUMERO1
            // 
            this.NUMERO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMERO1.Location = new System.Drawing.Point(879, 205);
            this.NUMERO1.MinimumSize = new System.Drawing.Size(40, 0);
            this.NUMERO1.Name = "NUMERO1";
            this.NUMERO1.Size = new System.Drawing.Size(200, 31);
            this.NUMERO1.TabIndex = 15;
            this.NUMERO1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NAFTA",
            "ACEITE",
            "GNC"});
            this.comboBox1.Location = new System.Drawing.Point(879, 150);
            this.comboBox1.MaxLength = 23;
            this.comboBox1.MinimumSize = new System.Drawing.Size(200, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 33);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.BackColor = System.Drawing.Color.Transparent;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.Cyan;
            this.L1.Location = new System.Drawing.Point(716, 66);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(363, 25);
            this.L1.TabIndex = 16;
            this.L1.Text = "Selccione Una Opcion A Comprar";
            this.L1.Visible = false;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.BackColor = System.Drawing.Color.Transparent;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.ForeColor = System.Drawing.Color.Cyan;
            this.L2.Location = new System.Drawing.Point(692, 103);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(387, 25);
            this.L2.TabIndex = 17;
            this.L2.Text = "Selecionando Producto Y Cantidad:";
            this.L2.Visible = false;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.BackColor = System.Drawing.Color.Transparent;
            this.L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.ForeColor = System.Drawing.Color.Cyan;
            this.L3.Location = new System.Drawing.Point(747, 150);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(113, 25);
            this.L3.TabIndex = 18;
            this.L3.Text = "Producto:";
            this.L3.Visible = false;
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.BackColor = System.Drawing.Color.Transparent;
            this.L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L4.ForeColor = System.Drawing.Color.Cyan;
            this.L4.Location = new System.Drawing.Point(760, 200);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(113, 25);
            this.L4.TabIndex = 19;
            this.L4.Text = "Cantidad:";
            this.L4.Visible = false;
            // 
            // VOLVER
            // 
            this.VOLVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOLVER.Location = new System.Drawing.Point(141, 205);
            this.VOLVER.Name = "VOLVER";
            this.VOLVER.Size = new System.Drawing.Size(113, 45);
            this.VOLVER.TabIndex = 20;
            this.VOLVER.Text = "VOLVER";
            this.VOLVER.UseVisualStyleBackColor = true;
            this.VOLVER.Visible = false;
            this.VOLVER.Click += new System.EventHandler(this.button2_Click);
            // 
            // vercompra
            // 
            this.vercompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vercompra.Location = new System.Drawing.Point(959, 316);
            this.vercompra.Name = "vercompra";
            this.vercompra.Size = new System.Drawing.Size(120, 66);
            this.vercompra.TabIndex = 21;
            this.vercompra.Text = "VER COMPRA";
            this.vercompra.UseVisualStyleBackColor = true;
            this.vercompra.Visible = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Cyan;
            this.lbltitulo.Location = new System.Drawing.Point(1159, 36);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(129, 33);
            this.lbltitulo.TabIndex = 22;
            this.lbltitulo.Text = "Precios:";
            this.lbltitulo.Visible = false;
            // 
            // lblnafta
            // 
            this.lblnafta.AutoSize = true;
            this.lblnafta.BackColor = System.Drawing.Color.Transparent;
            this.lblnafta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnafta.ForeColor = System.Drawing.Color.Cyan;
            this.lblnafta.Location = new System.Drawing.Point(1110, 94);
            this.lblnafta.Name = "lblnafta";
            this.lblnafta.Size = new System.Drawing.Size(216, 37);
            this.lblnafta.TabIndex = 23;
            this.lblnafta.Text = "NAFTA:$450";
            this.lblnafta.Visible = false;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.Cyan;
            this.lbltimer.Location = new System.Drawing.Point(12, 395);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(0, 39);
            this.lbltimer.TabIndex = 24;
            // 
            // lblgnc
            // 
            this.lblgnc.AutoSize = true;
            this.lblgnc.BackColor = System.Drawing.Color.Transparent;
            this.lblgnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgnc.ForeColor = System.Drawing.Color.Cyan;
            this.lblgnc.Location = new System.Drawing.Point(1139, 141);
            this.lblgnc.Name = "lblgnc";
            this.lblgnc.Size = new System.Drawing.Size(178, 37);
            this.lblgnc.TabIndex = 25;
            this.lblgnc.Text = "GNC:$270";
            this.lblgnc.Visible = false;
            // 
            // lblaceite
            // 
            this.lblaceite.AutoSize = true;
            this.lblaceite.BackColor = System.Drawing.Color.Transparent;
            this.lblaceite.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaceite.ForeColor = System.Drawing.Color.Cyan;
            this.lblaceite.Location = new System.Drawing.Point(1101, 188);
            this.lblaceite.Name = "lblaceite";
            this.lblaceite.Size = new System.Drawing.Size(241, 37);
            this.lblaceite.TabIndex = 26;
            this.lblaceite.Text = "ACEITE:$1200";
            this.lblaceite.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Cyan;
            this.lblfecha.Location = new System.Drawing.Point(12, 453);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 39);
            this.lblfecha.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramaDescuento.Properties.Resources.istockphoto_183891014_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 542);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblaceite);
            this.Controls.Add(this.lblgnc);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.lblnafta);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.vercompra);
            this.Controls.Add(this.VOLVER);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.NUMERO1);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTNACCEDER);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL3);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BARRA1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.NUMERO1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BARRA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.Button BTNACCEDER;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.NumericUpDown NUMERO1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Button VOLVER;
        private System.Windows.Forms.Button vercompra;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnafta;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lblgnc;
        private System.Windows.Forms.Label lblaceite;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblfecha;
    }
}

