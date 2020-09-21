namespace Presentation.Forms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnPagoServivios = new FontAwesome.Sharp.IconButton();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnArticulos = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnDash = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBotton = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.LblTitleChildForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(780, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.panelMenu.Controls.Add(this.btnFactura);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.btnPagoServivios);
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnArticulos);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnDash);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 774);
            this.panelMenu.TabIndex = 1;
            // 
            // btnFactura
            // 
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFactura.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnFactura.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFactura.IconSize = 32;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(0, 560);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFactura.Rotation = 0D;
            this.btnFactura.Size = new System.Drawing.Size(220, 60);
            this.btnFactura.TabIndex = 9;
            this.btnFactura.Text = "   Factura";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconSize = 32;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 500);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUser.Rotation = 0D;
            this.btnUser.Size = new System.Drawing.Size(220, 60);
            this.btnUser.TabIndex = 8;
            this.btnUser.Text = "   Usuarios";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPagoServivios
            // 
            this.btnPagoServivios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagoServivios.FlatAppearance.BorderSize = 0;
            this.btnPagoServivios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoServivios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPagoServivios.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnPagoServivios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagoServivios.IconChar = FontAwesome.Sharp.IconChar.CcVisa;
            this.btnPagoServivios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPagoServivios.IconSize = 32;
            this.btnPagoServivios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagoServivios.Location = new System.Drawing.Point(0, 440);
            this.btnPagoServivios.Name = "btnPagoServivios";
            this.btnPagoServivios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPagoServivios.Rotation = 0D;
            this.btnPagoServivios.Size = new System.Drawing.Size(220, 60);
            this.btnPagoServivios.TabIndex = 7;
            this.btnPagoServivios.Text = "   Servicios";
            this.btnPagoServivios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagoServivios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagoServivios.UseVisualStyleBackColor = true;
            this.btnPagoServivios.Click += new System.EventHandler(this.btnPagoServivios_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfig.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConfig.IconSize = 32;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 714);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfig.Rotation = 0D;
            this.btnConfig.Size = new System.Drawing.Size(220, 60);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "   Configuracion";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconSize = 32;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 380);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Rotation = 0D;
            this.btnReportes.Size = new System.Drawing.Size(220, 60);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "   Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnInventario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.IconSize = 32;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 320);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInventario.Rotation = 0D;
            this.btnInventario.Size = new System.Drawing.Size(220, 60);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "   Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnArticulos.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnArticulos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArticulos.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnArticulos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnArticulos.IconSize = 32;
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.Location = new System.Drawing.Point(0, 260);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnArticulos.Rotation = 0D;
            this.btnArticulos.Size = new System.Drawing.Size(220, 60);
            this.btnArticulos.TabIndex = 3;
            this.btnArticulos.Text = "   Articulos";
            this.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconSize = 32;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 200);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Rotation = 0D;
            this.btnVentas.Size = new System.Drawing.Size(220, 60);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "   Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDash.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDash.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btnDash.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDash.IconSize = 32;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(0, 140);
            this.btnDash.Name = "btnDash";
            this.btnDash.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDash.Rotation = 0D;
            this.btnDash.Size = new System.Drawing.Size(220, 60);
            this.btnDash.TabIndex = 1;
            this.btnDash.Text = "   Dashboard";
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // panelBotton
            // 
            this.panelBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.panelBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotton.Location = new System.Drawing.Point(220, 734);
            this.panelBotton.Name = "panelBotton";
            this.panelBotton.Size = new System.Drawing.Size(998, 40);
            this.panelBotton.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.panelTop.Controls.Add(this.LblTitleChildForm);
            this.panelTop.Controls.Add(this.IconCurrentChildForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(998, 40);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(220, 140);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChildForm.IconSize = 40;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(3, 0);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(43, 40);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // LblTitleChildForm
            // 
            this.LblTitleChildForm.AutoSize = true;
            this.LblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblTitleChildForm.Location = new System.Drawing.Point(53, 13);
            this.LblTitleChildForm.Name = "LblTitleChildForm";
            this.LblTitleChildForm.Size = new System.Drawing.Size(36, 16);
            this.LblTitleChildForm.TabIndex = 1;
            this.LblTitleChildForm.Text = "Inicio";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1218, 774);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBotton);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnFactura;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnPagoServivios;
        private FontAwesome.Sharp.IconButton btnConfig;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnArticulos;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnDash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBotton;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Label LblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
    }
}