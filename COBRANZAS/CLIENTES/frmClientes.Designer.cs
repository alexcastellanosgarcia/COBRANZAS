
namespace COBRANZAS.CLIENTES
{
    partial class frmClientes
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
            this.btnCBuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbxid = new MaterialSkin.Controls.MaterialTextBox();
            this.tbxnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbxidentidad = new MaterialSkin.Controls.MaterialTextBox();
            this.tbxtelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.tbxcorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.tbxdireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tbxmunicipio = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblFechaCreacion = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreadopor = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblFechaMod = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuarioMod = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCBuscar
            // 
            this.btnCBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCBuscar.Depth = 0;
            this.btnCBuscar.HighEmphasis = true;
            this.btnCBuscar.Icon = null;
            this.btnCBuscar.Location = new System.Drawing.Point(286, 21);
            this.btnCBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCBuscar.Name = "btnCBuscar";
            this.btnCBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnCBuscar.TabIndex = 2;
            this.btnCBuscar.Text = "Buscar";
            this.btnCBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCBuscar.UseAccentColor = false;
            this.btnCBuscar.UseVisualStyleBackColor = true;
            this.btnCBuscar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Cliente ID";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // tbxid
            // 
            this.tbxid.AnimateReadOnly = false;
            this.tbxid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxid.Depth = 0;
            this.tbxid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxid.LeadingIcon = null;
            this.tbxid.Location = new System.Drawing.Point(135, 18);
            this.tbxid.MaxLength = 50;
            this.tbxid.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxid.Multiline = false;
            this.tbxid.Name = "tbxid";
            this.tbxid.Size = new System.Drawing.Size(132, 50);
            this.tbxid.TabIndex = 1;
            this.tbxid.Text = "";
            this.tbxid.TrailingIcon = null;
            // 
            // tbxnombre
            // 
            this.tbxnombre.AnimateReadOnly = false;
            this.tbxnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxnombre.Depth = 0;
            this.tbxnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxnombre.LeadingIcon = null;
            this.tbxnombre.Location = new System.Drawing.Point(135, 130);
            this.tbxnombre.MaxLength = 50;
            this.tbxnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxnombre.Multiline = false;
            this.tbxnombre.Name = "tbxnombre";
            this.tbxnombre.Size = new System.Drawing.Size(335, 50);
            this.tbxnombre.TabIndex = 6;
            this.tbxnombre.Text = "";
            this.tbxnombre.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 91);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Identidad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(28, 145);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(57, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Nombre";
            // 
            // tbxidentidad
            // 
            this.tbxidentidad.AnimateReadOnly = false;
            this.tbxidentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxidentidad.Depth = 0;
            this.tbxidentidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxidentidad.LeadingIcon = null;
            this.tbxidentidad.Location = new System.Drawing.Point(135, 74);
            this.tbxidentidad.MaxLength = 50;
            this.tbxidentidad.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxidentidad.Multiline = false;
            this.tbxidentidad.Name = "tbxidentidad";
            this.tbxidentidad.Size = new System.Drawing.Size(335, 50);
            this.tbxidentidad.TabIndex = 4;
            this.tbxidentidad.Text = "";
            this.tbxidentidad.TrailingIcon = null;
            // 
            // tbxtelefono
            // 
            this.tbxtelefono.AnimateReadOnly = false;
            this.tbxtelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxtelefono.Depth = 0;
            this.tbxtelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxtelefono.LeadingIcon = null;
            this.tbxtelefono.Location = new System.Drawing.Point(135, 242);
            this.tbxtelefono.MaxLength = 50;
            this.tbxtelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxtelefono.Multiline = false;
            this.tbxtelefono.Name = "tbxtelefono";
            this.tbxtelefono.Size = new System.Drawing.Size(335, 50);
            this.tbxtelefono.TabIndex = 10;
            this.tbxtelefono.Text = "";
            this.tbxtelefono.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(28, 259);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Telefono";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(306, 417);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // tbxcorreo
            // 
            this.tbxcorreo.AnimateReadOnly = false;
            this.tbxcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxcorreo.Depth = 0;
            this.tbxcorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxcorreo.LeadingIcon = null;
            this.tbxcorreo.Location = new System.Drawing.Point(135, 298);
            this.tbxcorreo.MaxLength = 50;
            this.tbxcorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxcorreo.Multiline = false;
            this.tbxcorreo.Name = "tbxcorreo";
            this.tbxcorreo.Size = new System.Drawing.Size(335, 50);
            this.tbxcorreo.TabIndex = 12;
            this.tbxcorreo.Text = "";
            this.tbxcorreo.TrailingIcon = null;
            this.tbxcorreo.TextChanged += new System.EventHandler(this.tbxFechaNac_TextChanged);
            // 
            // tbxdireccion
            // 
            this.tbxdireccion.AnimateReadOnly = false;
            this.tbxdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxdireccion.Depth = 0;
            this.tbxdireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxdireccion.LeadingIcon = null;
            this.tbxdireccion.Location = new System.Drawing.Point(135, 186);
            this.tbxdireccion.MaxLength = 50;
            this.tbxdireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxdireccion.Multiline = false;
            this.tbxdireccion.Name = "tbxdireccion";
            this.tbxdireccion.Size = new System.Drawing.Size(335, 50);
            this.tbxdireccion.TabIndex = 8;
            this.tbxdireccion.Text = "";
            this.tbxdireccion.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(28, 199);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(67, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Direccion";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(28, 316);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Correo";
            // 
            // tbxmunicipio
            // 
            this.tbxmunicipio.AnimateReadOnly = false;
            this.tbxmunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxmunicipio.Depth = 0;
            this.tbxmunicipio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxmunicipio.LeadingIcon = null;
            this.tbxmunicipio.Location = new System.Drawing.Point(135, 354);
            this.tbxmunicipio.MaxLength = 50;
            this.tbxmunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxmunicipio.Multiline = false;
            this.tbxmunicipio.Name = "tbxmunicipio";
            this.tbxmunicipio.Size = new System.Drawing.Size(335, 50);
            this.tbxmunicipio.TabIndex = 14;
            this.tbxmunicipio.Text = "";
            this.tbxmunicipio.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(28, 368);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(71, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Municipio";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(163, 423);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(127, 26);
            this.dtpFechaNac.TabIndex = 16;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(28, 427);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(129, 19);
            this.materialLabel8.TabIndex = 15;
            this.materialLabel8.Text = "Fecha Nacimiento";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblUsuarioMod);
            this.materialCard1.Controls.Add(this.lblFechaMod);
            this.materialCard1.Controls.Add(this.dgvClientes);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.lblCreadopor);
            this.materialCard1.Controls.Add(this.lblFechaCreacion);
            this.materialCard1.Controls.Add(this.tbxid);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.btnCBuscar);
            this.materialCard1.Controls.Add(this.dtpFechaNac);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.tbxnombre);
            this.materialCard1.Controls.Add(this.tbxmunicipio);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.tbxidentidad);
            this.materialCard1.Controls.Add(this.tbxdireccion);
            this.materialCard1.Controls.Add(this.tbxtelefono);
            this.materialCard1.Controls.Add(this.tbxcorreo);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.btnGuardar);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.Black;
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1246, 540);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Depth = 0;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaCreacion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFechaCreacion.Location = new System.Drawing.Point(259, 494);
            this.lblFechaCreacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(75, 19);
            this.lblFechaCreacion.TabIndex = 18;
            this.lblFechaCreacion.Text = "Creado el: ";
            this.lblFechaCreacion.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // lblCreadopor
            // 
            this.lblCreadopor.AutoSize = true;
            this.lblCreadopor.Depth = 0;
            this.lblCreadopor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreadopor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCreadopor.Location = new System.Drawing.Point(28, 494);
            this.lblCreadopor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreadopor.Name = "lblCreadopor";
            this.lblCreadopor.Size = new System.Drawing.Size(86, 19);
            this.lblCreadopor.TabIndex = 19;
            this.lblCreadopor.Text = "Creado por: ";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(412, 417);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(79, 36);
            this.materialButton1.TabIndex = 20;
            this.materialButton1.Text = "Limpiar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_2);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(521, 211);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(681, 198);
            this.dgvClientes.TabIndex = 21;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblFechaMod
            // 
            this.lblFechaMod.AutoSize = true;
            this.lblFechaMod.Depth = 0;
            this.lblFechaMod.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaMod.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFechaMod.Location = new System.Drawing.Point(811, 494);
            this.lblFechaMod.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaMod.Name = "lblFechaMod";
            this.lblFechaMod.Size = new System.Drawing.Size(110, 19);
            this.lblFechaMod.TabIndex = 22;
            this.lblFechaMod.Text = "Modificado el:  ";
            // 
            // lblUsuarioMod
            // 
            this.lblUsuarioMod.AutoSize = true;
            this.lblUsuarioMod.Depth = 0;
            this.lblUsuarioMod.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuarioMod.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUsuarioMod.Location = new System.Drawing.Point(572, 494);
            this.lblUsuarioMod.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuarioMod.Name = "lblUsuarioMod";
            this.lblUsuarioMod.Size = new System.Drawing.Size(121, 19);
            this.lblUsuarioMod.TabIndex = 23;
            this.lblUsuarioMod.Text = "Modificado por:  ";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 635);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox tbxid;
        private MaterialSkin.Controls.MaterialTextBox tbxnombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox tbxidentidad;
        private MaterialSkin.Controls.MaterialTextBox tbxtelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox tbxcorreo;
        private MaterialSkin.Controls.MaterialTextBox tbxdireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox tbxmunicipio;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblFechaCreacion;
        private MaterialSkin.Controls.MaterialLabel lblCreadopor;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private MaterialSkin.Controls.MaterialLabel lblUsuarioMod;
        private MaterialSkin.Controls.MaterialLabel lblFechaMod;
    }
}