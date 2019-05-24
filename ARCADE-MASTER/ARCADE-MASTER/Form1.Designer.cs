namespace ARCADE_MASTER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.lbCopirigth = new System.Windows.Forms.Label();
            this.btnScoresMenu = new System.Windows.Forms.Button();
            this.btnAjustesMenu = new System.Windows.Forms.Button();
            this.btnIniciarMenu = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tabAjustes = new System.Windows.Forms.TabPage();
            this.tabMarcadores = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabMonopolio = new System.Windows.Forms.TabPage();
            this.tabAjedrez = new System.Windows.Forms.TabPage();
            this.tabRompecabezas = new System.Windows.Forms.TabPage();
            this.tabOca = new System.Windows.Forms.TabPage();
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.btnMenu3 = new System.Windows.Forms.Button();
            this.btnMenu4 = new System.Windows.Forms.Button();
            this.lbElegirRompecabezas = new System.Windows.Forms.Label();
            this.btnOpcion1RP = new System.Windows.Forms.Button();
            this.btnOpcion3RP = new System.Windows.Forms.Button();
            this.btnOpcion4RP = new System.Windows.Forms.Button();
            this.btnOpcion2RP = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabMonopolio.SuspendLayout();
            this.tabAjedrez.SuspendLayout();
            this.tabRompecabezas.SuspendLayout();
            this.tabOca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Controls.Add(this.tabAjustes);
            this.tabControl1.Controls.Add(this.tabMarcadores);
            this.tabControl1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1145, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabControl2);
            this.tabMenu.Controls.Add(this.lbCopirigth);
            this.tabMenu.Controls.Add(this.btnScoresMenu);
            this.tabMenu.Controls.Add(this.btnAjustesMenu);
            this.tabMenu.Controls.Add(this.btnIniciarMenu);
            this.tabMenu.Controls.Add(this.lbTitulo);
            this.tabMenu.Location = new System.Drawing.Point(4, 29);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1137, 597);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "MENU";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // lbCopirigth
            // 
            this.lbCopirigth.AutoSize = true;
            this.lbCopirigth.Font = new System.Drawing.Font("Showcard Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopirigth.Location = new System.Drawing.Point(986, 570);
            this.lbCopirigth.Name = "lbCopirigth";
            this.lbCopirigth.Size = new System.Drawing.Size(148, 24);
            this.lbCopirigth.TabIndex = 4;
            this.lbCopirigth.Text = "                         EMI © 2019\r\nTODOS LOS DERECHOS RESERVADOS ";
            // 
            // btnScoresMenu
            // 
            this.btnScoresMenu.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoresMenu.Location = new System.Drawing.Point(491, 474);
            this.btnScoresMenu.Name = "btnScoresMenu";
            this.btnScoresMenu.Size = new System.Drawing.Size(134, 61);
            this.btnScoresMenu.TabIndex = 3;
            this.btnScoresMenu.Text = "SCORES";
            this.btnScoresMenu.UseVisualStyleBackColor = true;
            this.btnScoresMenu.Click += new System.EventHandler(this.BtnScoresMenu_Click);
            // 
            // btnAjustesMenu
            // 
            this.btnAjustesMenu.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustesMenu.Location = new System.Drawing.Point(491, 378);
            this.btnAjustesMenu.Name = "btnAjustesMenu";
            this.btnAjustesMenu.Size = new System.Drawing.Size(134, 61);
            this.btnAjustesMenu.TabIndex = 2;
            this.btnAjustesMenu.Text = "AJUSTES";
            this.btnAjustesMenu.UseVisualStyleBackColor = true;
            this.btnAjustesMenu.Click += new System.EventHandler(this.BtnAjustesMenu_Click);
            // 
            // btnIniciarMenu
            // 
            this.btnIniciarMenu.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarMenu.Location = new System.Drawing.Point(491, 287);
            this.btnIniciarMenu.Name = "btnIniciarMenu";
            this.btnIniciarMenu.Size = new System.Drawing.Size(134, 61);
            this.btnIniciarMenu.TabIndex = 1;
            this.btnIniciarMenu.Text = "JUGAR";
            this.btnIniciarMenu.UseVisualStyleBackColor = true;
            this.btnIniciarMenu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitulo.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.Location = new System.Drawing.Point(161, 98);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(799, 119);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "ARCADE MASTER";
            // 
            // tabAjustes
            // 
            this.tabAjustes.Location = new System.Drawing.Point(4, 29);
            this.tabAjustes.Name = "tabAjustes";
            this.tabAjustes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjustes.Size = new System.Drawing.Size(1137, 597);
            this.tabAjustes.TabIndex = 1;
            this.tabAjustes.Text = "AJUSTES";
            this.tabAjustes.UseVisualStyleBackColor = true;
            // 
            // tabMarcadores
            // 
            this.tabMarcadores.Location = new System.Drawing.Point(4, 29);
            this.tabMarcadores.Name = "tabMarcadores";
            this.tabMarcadores.Size = new System.Drawing.Size(1137, 597);
            this.tabMarcadores.TabIndex = 2;
            this.tabMarcadores.Text = "MARCADORES";
            this.tabMarcadores.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabMonopolio);
            this.tabControl2.Controls.Add(this.tabAjedrez);
            this.tabControl2.Controls.Add(this.tabRompecabezas);
            this.tabControl2.Controls.Add(this.tabOca);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1138, 598);
            this.tabControl2.TabIndex = 5;
            this.tabControl2.Visible = false;
            // 
            // tabMonopolio
            // 
            this.tabMonopolio.Controls.Add(this.btnMenu1);
            this.tabMonopolio.Location = new System.Drawing.Point(4, 29);
            this.tabMonopolio.Name = "tabMonopolio";
            this.tabMonopolio.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonopolio.Size = new System.Drawing.Size(1130, 565);
            this.tabMonopolio.TabIndex = 0;
            this.tabMonopolio.Text = "MONOPOLIO";
            this.tabMonopolio.UseVisualStyleBackColor = true;
            // 
            // tabAjedrez
            // 
            this.tabAjedrez.Controls.Add(this.btnMenu2);
            this.tabAjedrez.Location = new System.Drawing.Point(4, 29);
            this.tabAjedrez.Name = "tabAjedrez";
            this.tabAjedrez.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjedrez.Size = new System.Drawing.Size(1130, 565);
            this.tabAjedrez.TabIndex = 1;
            this.tabAjedrez.Text = "AJEDREZ";
            this.tabAjedrez.UseVisualStyleBackColor = true;
            // 
            // tabRompecabezas
            // 
            this.tabRompecabezas.Controls.Add(this.btnOpcion2RP);
            this.tabRompecabezas.Controls.Add(this.btnOpcion4RP);
            this.tabRompecabezas.Controls.Add(this.btnOpcion3RP);
            this.tabRompecabezas.Controls.Add(this.btnOpcion1RP);
            this.tabRompecabezas.Controls.Add(this.lbElegirRompecabezas);
            this.tabRompecabezas.Controls.Add(this.btnMenu3);
            this.tabRompecabezas.Location = new System.Drawing.Point(4, 29);
            this.tabRompecabezas.Name = "tabRompecabezas";
            this.tabRompecabezas.Padding = new System.Windows.Forms.Padding(3);
            this.tabRompecabezas.Size = new System.Drawing.Size(1130, 565);
            this.tabRompecabezas.TabIndex = 2;
            this.tabRompecabezas.Text = "ROMPECABEZAS";
            this.tabRompecabezas.UseVisualStyleBackColor = true;
            // 
            // tabOca
            // 
            this.tabOca.Controls.Add(this.btnMenu4);
            this.tabOca.Location = new System.Drawing.Point(4, 29);
            this.tabOca.Name = "tabOca";
            this.tabOca.Padding = new System.Windows.Forms.Padding(3);
            this.tabOca.Size = new System.Drawing.Size(1130, 565);
            this.tabOca.TabIndex = 3;
            this.tabOca.Text = "OCA LOCA";
            this.tabOca.UseVisualStyleBackColor = true;
            // 
            // btnMenu1
            // 
            this.btnMenu1.Location = new System.Drawing.Point(1061, 6);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(63, 32);
            this.btnMenu1.TabIndex = 6;
            this.btnMenu1.Text = "MENU";
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.BtnMenu1_Click);
            // 
            // btnMenu2
            // 
            this.btnMenu2.Location = new System.Drawing.Point(1061, 6);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(63, 32);
            this.btnMenu2.TabIndex = 7;
            this.btnMenu2.Text = "MENU";
            this.btnMenu2.UseVisualStyleBackColor = true;
            this.btnMenu2.Click += new System.EventHandler(this.BtnMenu2_Click);
            // 
            // btnMenu3
            // 
            this.btnMenu3.Location = new System.Drawing.Point(1061, 6);
            this.btnMenu3.Name = "btnMenu3";
            this.btnMenu3.Size = new System.Drawing.Size(63, 32);
            this.btnMenu3.TabIndex = 7;
            this.btnMenu3.Text = "MENU";
            this.btnMenu3.UseVisualStyleBackColor = true;
            this.btnMenu3.Click += new System.EventHandler(this.BtnMenu3_Click);
            // 
            // btnMenu4
            // 
            this.btnMenu4.Location = new System.Drawing.Point(1064, 6);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(63, 32);
            this.btnMenu4.TabIndex = 7;
            this.btnMenu4.Text = "MENU";
            this.btnMenu4.UseVisualStyleBackColor = true;
            this.btnMenu4.Click += new System.EventHandler(this.BtnMenu4_Click);
            // 
            // lbElegirRompecabezas
            // 
            this.lbElegirRompecabezas.AutoSize = true;
            this.lbElegirRompecabezas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbElegirRompecabezas.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElegirRompecabezas.ForeColor = System.Drawing.SystemColors.Control;
            this.lbElegirRompecabezas.Location = new System.Drawing.Point(297, 88);
            this.lbElegirRompecabezas.Name = "lbElegirRompecabezas";
            this.lbElegirRompecabezas.Size = new System.Drawing.Size(554, 30);
            this.lbElegirRompecabezas.TabIndex = 8;
            this.lbElegirRompecabezas.Text = "ESCOJA UNO DE LOS SIGUIENTES ROMPECABEZAS";
            // 
            // btnOpcion1RP
            // 
            this.btnOpcion1RP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpcion1RP.BackgroundImage")));
            this.btnOpcion1RP.Location = new System.Drawing.Point(55, 201);
            this.btnOpcion1RP.Name = "btnOpcion1RP";
            this.btnOpcion1RP.Size = new System.Drawing.Size(187, 209);
            this.btnOpcion1RP.TabIndex = 9;
            this.btnOpcion1RP.UseVisualStyleBackColor = true;
            // 
            // btnOpcion3RP
            // 
            this.btnOpcion3RP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpcion3RP.BackgroundImage")));
            this.btnOpcion3RP.Location = new System.Drawing.Point(615, 201);
            this.btnOpcion3RP.Name = "btnOpcion3RP";
            this.btnOpcion3RP.Size = new System.Drawing.Size(187, 209);
            this.btnOpcion3RP.TabIndex = 10;
            this.btnOpcion3RP.UseVisualStyleBackColor = true;
            // 
            // btnOpcion4RP
            // 
            this.btnOpcion4RP.Location = new System.Drawing.Point(880, 201);
            this.btnOpcion4RP.Name = "btnOpcion4RP";
            this.btnOpcion4RP.Size = new System.Drawing.Size(187, 209);
            this.btnOpcion4RP.TabIndex = 11;
            this.btnOpcion4RP.UseVisualStyleBackColor = true;
            // 
            // btnOpcion2RP
            // 
            this.btnOpcion2RP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpcion2RP.BackgroundImage")));
            this.btnOpcion2RP.Location = new System.Drawing.Point(339, 201);
            this.btnOpcion2RP.Name = "btnOpcion2RP";
            this.btnOpcion2RP.Size = new System.Drawing.Size(187, 209);
            this.btnOpcion2RP.TabIndex = 12;
            this.btnOpcion2RP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARCADE MASTER 2019";
            this.tabControl1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabMonopolio.ResumeLayout(false);
            this.tabAjedrez.ResumeLayout(false);
            this.tabRompecabezas.ResumeLayout(false);
            this.tabRompecabezas.PerformLayout();
            this.tabOca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabAjustes;
        private System.Windows.Forms.TabPage tabMarcadores;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnScoresMenu;
        private System.Windows.Forms.Button btnAjustesMenu;
        private System.Windows.Forms.Button btnIniciarMenu;
        private System.Windows.Forms.Label lbCopirigth;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabMonopolio;
        private System.Windows.Forms.TabPage tabAjedrez;
        private System.Windows.Forms.TabPage tabRompecabezas;
        private System.Windows.Forms.TabPage tabOca;
        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.Button btnMenu3;
        private System.Windows.Forms.Button btnMenu4;
        private System.Windows.Forms.Button btnOpcion2RP;
        private System.Windows.Forms.Button btnOpcion4RP;
        private System.Windows.Forms.Button btnOpcion3RP;
        private System.Windows.Forms.Button btnOpcion1RP;
        private System.Windows.Forms.Label lbElegirRompecabezas;
    }
}

