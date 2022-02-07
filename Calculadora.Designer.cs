namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.CajaResultado = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnLimpiarT = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.labHistorial = new System.Windows.Forms.Label();
            this.btnABS = new System.Windows.Forms.Button();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.labVista = new System.Windows.Forms.Label();
            this.btnCubo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CajaResultado
            // 
            this.CajaResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CajaResultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CajaResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaResultado.Location = new System.Drawing.Point(35, 49);
            this.CajaResultado.Name = "CajaResultado";
            this.CajaResultado.ReadOnly = true;
            this.CajaResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CajaResultado.Size = new System.Drawing.Size(201, 32);
            this.CajaResultado.TabIndex = 10;
            this.CajaResultado.Text = "0";
            this.CajaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            this.btnUno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUno.BackColor = System.Drawing.Color.DimGray;
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUno.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(34, 285);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(49, 40);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDos.BackColor = System.Drawing.Color.DimGray;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(85, 285);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(49, 40);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTres.BackColor = System.Drawing.Color.DimGray;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTres.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(136, 285);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(49, 40);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeis.BackColor = System.Drawing.Color.DimGray;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeis.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(136, 239);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(49, 40);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCinco.BackColor = System.Drawing.Color.DimGray;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCinco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(85, 239);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(49, 40);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCuatro.BackColor = System.Drawing.Color.DimGray;
            this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCuatro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(34, 239);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(49, 40);
            this.btnCuatro.TabIndex = 4;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNueve.BackColor = System.Drawing.Color.DimGray;
            this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNueve.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(136, 193);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(49, 40);
            this.btnNueve.TabIndex = 9;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOcho.BackColor = System.Drawing.Color.DimGray;
            this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOcho.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(85, 193);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(49, 40);
            this.btnOcho.TabIndex = 8;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSiete.BackColor = System.Drawing.Color.DimGray;
            this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSiete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(34, 193);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(49, 40);
            this.btnSiete.TabIndex = 7;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPunto.BackColor = System.Drawing.Color.DimGray;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPunto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(136, 331);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(49, 40);
            this.btnPunto.TabIndex = 11;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnCero
            // 
            this.btnCero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCero.BackColor = System.Drawing.Color.DimGray;
            this.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(34, 331);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(100, 40);
            this.btnCero.TabIndex = 0;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDividir.BackColor = System.Drawing.Color.DimGray;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDividir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(187, 147);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(49, 40);
            this.btnDividir.TabIndex = 13;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMultiplicar.BackColor = System.Drawing.Color.DimGray;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMultiplicar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(187, 193);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(49, 40);
            this.btnMultiplicar.TabIndex = 14;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestar.BackColor = System.Drawing.Color.DimGray;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(187, 239);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(49, 40);
            this.btnRestar.TabIndex = 15;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSumar.BackColor = System.Drawing.Color.DimGray;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSumar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(187, 285);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(49, 40);
            this.btnSumar.TabIndex = 16;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnLimpiarT
            // 
            this.btnLimpiarT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiarT.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiarT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarT.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarT.Location = new System.Drawing.Point(136, 101);
            this.btnLimpiarT.Name = "btnLimpiarT";
            this.btnLimpiarT.Size = new System.Drawing.Size(49, 40);
            this.btnLimpiarT.TabIndex = 18;
            this.btnLimpiarT.Text = "C";
            this.btnLimpiarT.UseVisualStyleBackColor = false;
            this.btnLimpiarT.Click += new System.EventHandler(this.btnLimpiarT_Click);
            // 
            // btnMod
            // 
            this.btnMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMod.BackColor = System.Drawing.Color.DimGray;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMod.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(85, 101);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(49, 40);
            this.btnMod.TabIndex = 22;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResultado.BackColor = System.Drawing.Color.DimGray;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResultado.Location = new System.Drawing.Point(187, 331);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(49, 40);
            this.btnResultado.TabIndex = 17;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPotencia.BackColor = System.Drawing.Color.DimGray;
            this.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPotencia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(85, 147);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(49, 40);
            this.btnPotencia.TabIndex = 21;
            this.btnPotencia.Text = "X²";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRaiz.BackColor = System.Drawing.Color.DimGray;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRaiz.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(34, 101);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(49, 40);
            this.btnRaiz.TabIndex = 19;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // labHistorial
            // 
            this.labHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labHistorial.AutoSize = true;
            this.labHistorial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHistorial.ForeColor = System.Drawing.Color.Black;
            this.labHistorial.Location = new System.Drawing.Point(32, 28);
            this.labHistorial.Name = "labHistorial";
            this.labHistorial.Size = new System.Drawing.Size(0, 17);
            this.labHistorial.TabIndex = 25;
            // 
            // btnABS
            // 
            this.btnABS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnABS.BackColor = System.Drawing.Color.DimGray;
            this.btnABS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnABS.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABS.Location = new System.Drawing.Point(136, 147);
            this.btnABS.Name = "btnABS";
            this.btnABS.Size = new System.Drawing.Size(49, 40);
            this.btnABS.TabIndex = 24;
            this.btnABS.Text = "±";
            this.btnABS.UseVisualStyleBackColor = false;
            this.btnABS.Click += new System.EventHandler(this.btnAproximacion_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.IconSize = 25;
            this.btnBorrar.Location = new System.Drawing.Point(187, 101);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(49, 40);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // labVista
            // 
            this.labVista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labVista.AutoSize = true;
            this.labVista.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVista.ForeColor = System.Drawing.Color.Black;
            this.labVista.Location = new System.Drawing.Point(31, 9);
            this.labVista.Name = "labVista";
            this.labVista.Size = new System.Drawing.Size(47, 17);
            this.labVista.TabIndex = 26;
            this.labVista.Text = "Vista:";
            // 
            // btnCubo
            // 
            this.btnCubo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCubo.BackColor = System.Drawing.Color.DimGray;
            this.btnCubo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCubo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCubo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCubo.Location = new System.Drawing.Point(34, 147);
            this.btnCubo.Name = "btnCubo";
            this.btnCubo.Size = new System.Drawing.Size(49, 40);
            this.btnCubo.TabIndex = 27;
            this.btnCubo.Text = "x³";
            this.btnCubo.UseVisualStyleBackColor = false;
            this.btnCubo.Click += new System.EventHandler(this.btnCubo_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(270, 385);
            this.Controls.Add(this.btnCubo);
            this.Controls.Add(this.labVista);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnABS);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnLimpiarT);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.labHistorial);
            this.Controls.Add(this.CajaResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CajaResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnLimpiarT;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Label labHistorial;
        private System.Windows.Forms.Button btnABS;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private System.Windows.Forms.Label labVista;
        private System.Windows.Forms.Button btnCubo;
    }
}

