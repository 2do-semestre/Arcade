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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tabAjustes = new System.Windows.Forms.TabPage();
            this.tabMarcadores = new System.Windows.Forms.TabPage();
            this.btnIniciarMenu = new System.Windows.Forms.Button();
            this.btnAjustesMenu = new System.Windows.Forms.Button();
            this.btnScoresMenu = new System.Windows.Forms.Button();
            this.lbCopirigth = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Controls.Add(this.tabAjustes);
            this.tabControl1.Controls.Add(this.tabMarcadores);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1145, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.lbCopirigth);
            this.tabMenu.Controls.Add(this.btnScoresMenu);
            this.tabMenu.Controls.Add(this.btnAjustesMenu);
            this.tabMenu.Controls.Add(this.btnIniciarMenu);
            this.tabMenu.Controls.Add(this.lbTitulo);
            this.tabMenu.Location = new System.Drawing.Point(4, 23);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1137, 603);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "MENU";
            this.tabMenu.UseVisualStyleBackColor = true;
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
            this.tabAjustes.Location = new System.Drawing.Point(4, 23);
            this.tabAjustes.Name = "tabAjustes";
            this.tabAjustes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjustes.Size = new System.Drawing.Size(1137, 603);
            this.tabAjustes.TabIndex = 1;
            this.tabAjustes.Text = "AJUSTES";
            this.tabAjustes.UseVisualStyleBackColor = true;
            // 
            // tabMarcadores
            // 
            this.tabMarcadores.Location = new System.Drawing.Point(4, 23);
            this.tabMarcadores.Name = "tabMarcadores";
            this.tabMarcadores.Size = new System.Drawing.Size(1137, 603);
            this.tabMarcadores.TabIndex = 2;
            this.tabMarcadores.Text = "MARCADORES";
            this.tabMarcadores.UseVisualStyleBackColor = true;
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
            // btnAjustesMenu
            // 
            this.btnAjustesMenu.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustesMenu.Location = new System.Drawing.Point(491, 378);
            this.btnAjustesMenu.Name = "btnAjustesMenu";
            this.btnAjustesMenu.Size = new System.Drawing.Size(134, 61);
            this.btnAjustesMenu.TabIndex = 2;
            this.btnAjustesMenu.Text = "AJUSTES";
            this.btnAjustesMenu.UseVisualStyleBackColor = true;
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
            // 
            // lbCopirigth
            // 
            this.lbCopirigth.AutoSize = true;
            this.lbCopirigth.Font = new System.Drawing.Font("Showcard Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopirigth.Location = new System.Drawing.Point(983, 576);
            this.lbCopirigth.Name = "lbCopirigth";
            this.lbCopirigth.Size = new System.Drawing.Size(148, 24);
            this.lbCopirigth.TabIndex = 4;
            this.lbCopirigth.Text = "                         EMI © 2019\r\nTODOS LOS DERECHOS RESERVADOS ";
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
    }
}

