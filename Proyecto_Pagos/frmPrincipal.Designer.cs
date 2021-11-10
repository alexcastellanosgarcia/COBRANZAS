
namespace WindowsFormsApp1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabcontrolprincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tabclientes = new System.Windows.Forms.TabPage();
            this.tabservicios = new System.Windows.Forms.TabPage();
            this.tabmorosidad = new System.Windows.Forms.TabPage();
            this.tabconfiguracion = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabcontrolclientes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabregistro = new System.Windows.Forms.TabPage();
            this.tabconsulta = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabSelector4 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl3 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabcontrolprincipal.SuspendLayout();
            this.tabclientes.SuspendLayout();
            this.tabservicios.SuspendLayout();
            this.tabmorosidad.SuspendLayout();
            this.tabconfiguracion.SuspendLayout();
            this.tabcontrolclientes.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrolprincipal
            // 
            this.tabcontrolprincipal.Controls.Add(this.tabclientes);
            this.tabcontrolprincipal.Controls.Add(this.tabservicios);
            this.tabcontrolprincipal.Controls.Add(this.tabmorosidad);
            this.tabcontrolprincipal.Controls.Add(this.tabconfiguracion);
            this.tabcontrolprincipal.Depth = 0;
            this.tabcontrolprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolprincipal.ImageList = this.imageList1;
            this.tabcontrolprincipal.Location = new System.Drawing.Point(3, 64);
            this.tabcontrolprincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontrolprincipal.Multiline = true;
            this.tabcontrolprincipal.Name = "tabcontrolprincipal";
            this.tabcontrolprincipal.SelectedIndex = 0;
            this.tabcontrolprincipal.Size = new System.Drawing.Size(794, 383);
            this.tabcontrolprincipal.TabIndex = 0;
            // 
            // tabclientes
            // 
            this.tabclientes.Controls.Add(this.materialTabSelector1);
            this.tabclientes.Controls.Add(this.tabcontrolclientes);
            this.tabclientes.ImageKey = "cliente.png";
            this.tabclientes.Location = new System.Drawing.Point(4, 23);
            this.tabclientes.Name = "tabclientes";
            this.tabclientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabclientes.Size = new System.Drawing.Size(786, 356);
            this.tabclientes.TabIndex = 0;
            this.tabclientes.Text = "Clientes";
            this.tabclientes.UseVisualStyleBackColor = true;
            this.tabclientes.Click += new System.EventHandler(this.tabclientes_Click);
            // 
            // tabservicios
            // 
            this.tabservicios.Controls.Add(this.materialTabSelector2);
            this.tabservicios.Controls.Add(this.materialTabControl1);
            this.tabservicios.ImageKey = "services-portfolio-icon.png";
            this.tabservicios.Location = new System.Drawing.Point(4, 23);
            this.tabservicios.Name = "tabservicios";
            this.tabservicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabservicios.Size = new System.Drawing.Size(786, 356);
            this.tabservicios.TabIndex = 1;
            this.tabservicios.Text = "Servicios";
            this.tabservicios.UseVisualStyleBackColor = true;
            // 
            // tabmorosidad
            // 
            this.tabmorosidad.Controls.Add(this.materialTabSelector3);
            this.tabmorosidad.Controls.Add(this.materialTabControl2);
            this.tabmorosidad.ImageKey = "morosidad.png";
            this.tabmorosidad.Location = new System.Drawing.Point(4, 23);
            this.tabmorosidad.Name = "tabmorosidad";
            this.tabmorosidad.Size = new System.Drawing.Size(786, 356);
            this.tabmorosidad.TabIndex = 2;
            this.tabmorosidad.Text = "Morosidad";
            this.tabmorosidad.UseVisualStyleBackColor = true;
            // 
            // tabconfiguracion
            // 
            this.tabconfiguracion.Controls.Add(this.materialTabSelector4);
            this.tabconfiguracion.Controls.Add(this.materialTabControl3);
            this.tabconfiguracion.ImageKey = "Settings-icon.png";
            this.tabconfiguracion.Location = new System.Drawing.Point(4, 23);
            this.tabconfiguracion.Name = "tabconfiguracion";
            this.tabconfiguracion.Size = new System.Drawing.Size(786, 356);
            this.tabconfiguracion.TabIndex = 3;
            this.tabconfiguracion.Text = "Configuracion";
            this.tabconfiguracion.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cliente.png");
            this.imageList1.Images.SetKeyName(1, "morosidad.png");
            this.imageList1.Images.SetKeyName(2, "services-portfolio-icon.png");
            this.imageList1.Images.SetKeyName(3, "Settings-icon.png");
            // 
            // tabcontrolclientes
            // 
            this.tabcontrolclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontrolclientes.Controls.Add(this.tabregistro);
            this.tabcontrolclientes.Controls.Add(this.tabconsulta);
            this.tabcontrolclientes.Depth = 0;
            this.tabcontrolclientes.Location = new System.Drawing.Point(3, 43);
            this.tabcontrolclientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontrolclientes.Multiline = true;
            this.tabcontrolclientes.Name = "tabcontrolclientes";
            this.tabcontrolclientes.SelectedIndex = 0;
            this.tabcontrolclientes.Size = new System.Drawing.Size(777, 310);
            this.tabcontrolclientes.TabIndex = 0;
            // 
            // tabregistro
            // 
            this.tabregistro.Location = new System.Drawing.Point(4, 22);
            this.tabregistro.Name = "tabregistro";
            this.tabregistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabregistro.Size = new System.Drawing.Size(769, 284);
            this.tabregistro.TabIndex = 0;
            this.tabregistro.Text = "Registro";
            this.tabregistro.UseVisualStyleBackColor = true;
            // 
            // tabconsulta
            // 
            this.tabconsulta.Location = new System.Drawing.Point(4, 22);
            this.tabconsulta.Name = "tabconsulta";
            this.tabconsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabconsulta.Size = new System.Drawing.Size(769, 284);
            this.tabconsulta.TabIndex = 1;
            this.tabconsulta.Text = "Consulta";
            this.tabconsulta.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabcontrolclientes;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(6, 6);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(774, 31);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click_1);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(8, 5);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(774, 31);
            this.materialTabSelector2.TabIndex = 3;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(5, 42);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(777, 310);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector3.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector3.Location = new System.Drawing.Point(8, 5);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(774, 31);
            this.materialTabSelector3.TabIndex = 3;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(5, 42);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(777, 310);
            this.materialTabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(769, 284);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Registro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(769, 284);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Consulta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector4
            // 
            this.materialTabSelector4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector4.BaseTabControl = this.materialTabControl3;
            this.materialTabSelector4.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector4.Depth = 0;
            this.materialTabSelector4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector4.Location = new System.Drawing.Point(8, 5);
            this.materialTabSelector4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector4.Name = "materialTabSelector4";
            this.materialTabSelector4.Size = new System.Drawing.Size(774, 31);
            this.materialTabSelector4.TabIndex = 3;
            this.materialTabSelector4.Text = "materialTabSelector4";
            // 
            // materialTabControl3
            // 
            this.materialTabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl3.Controls.Add(this.tabPage5);
            this.materialTabControl3.Controls.Add(this.tabPage6);
            this.materialTabControl3.Depth = 0;
            this.materialTabControl3.Location = new System.Drawing.Point(5, 42);
            this.materialTabControl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl3.Multiline = true;
            this.materialTabControl3.Name = "materialTabControl3";
            this.materialTabControl3.SelectedIndex = 0;
            this.materialTabControl3.Size = new System.Drawing.Size(777, 310);
            this.materialTabControl3.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(769, 284);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Registro";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(769, 284);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Consulta";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrolprincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabcontrolprincipal;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Pagos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabcontrolprincipal.ResumeLayout(false);
            this.tabclientes.ResumeLayout(false);
            this.tabservicios.ResumeLayout(false);
            this.tabmorosidad.ResumeLayout(false);
            this.tabconfiguracion.ResumeLayout(false);
            this.tabcontrolclientes.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.materialTabControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabcontrolprincipal;
        private System.Windows.Forms.TabPage tabclientes;
        private System.Windows.Forms.TabPage tabservicios;
        private System.Windows.Forms.TabPage tabmorosidad;
        private System.Windows.Forms.TabPage tabconfiguracion;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabcontrolclientes;
        private System.Windows.Forms.TabPage tabregistro;
        private System.Windows.Forms.TabPage tabconsulta;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector4;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}

