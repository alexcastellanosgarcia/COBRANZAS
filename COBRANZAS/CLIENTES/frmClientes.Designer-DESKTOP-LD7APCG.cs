
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
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdentidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txttelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnCBuscar
            // 
            this.btnCBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCBuscar.Depth = 0;
            this.btnCBuscar.HighEmphasis = true;
            this.btnCBuscar.Icon = null;
            this.btnCBuscar.Location = new System.Drawing.Point(273, 100);
            this.btnCBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCBuscar.Name = "btnCBuscar";
            this.btnCBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnCBuscar.TabIndex = 0;
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
            this.materialLabel1.Location = new System.Drawing.Point(34, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Cliente ID";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(122, 86);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 50);
            this.txtID.TabIndex = 3;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(122, 153);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(335, 50);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(34, 235);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Identidad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(35, 168);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(57, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Nombre";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.AnimateReadOnly = false;
            this.txtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentidad.Depth = 0;
            this.txtIdentidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentidad.LeadingIcon = null;
            this.txtIdentidad.Location = new System.Drawing.Point(122, 224);
            this.txtIdentidad.MaxLength = 50;
            this.txtIdentidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdentidad.Multiline = false;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(335, 50);
            this.txtIdentidad.TabIndex = 7;
            this.txtIdentidad.Text = "";
            this.txtIdentidad.TrailingIcon = null;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(122, 296);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(335, 50);
            this.txtCorreo.TabIndex = 8;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(35, 298);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Correo";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(611, 420);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "Guardar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // txttelefono
            // 
            this.txttelefono.AnimateReadOnly = false;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono.Depth = 0;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txttelefono.LeadingIcon = null;
            this.txttelefono.Location = new System.Drawing.Point(122, 363);
            this.txttelefono.MaxLength = 50;
            this.txttelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txttelefono.Multiline = false;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(335, 50);
            this.txttelefono.TabIndex = 11;
            this.txttelefono.Text = "";
            this.txttelefono.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(35, 375);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Telefono";
            // 
            // txtdireccion
            // 
            this.txtdireccion.AnimateReadOnly = false;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdireccion.LeadingIcon = null;
            this.txtdireccion.Location = new System.Drawing.Point(122, 437);
            this.txtdireccion.MaxLength = 50;
            this.txtdireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdireccion.Multiline = false;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(335, 50);
            this.txtdireccion.TabIndex = 13;
            this.txtdireccion.Text = "";
            this.txtdireccion.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(35, 456);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 19);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Direccion";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(122, 506);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(335, 50);
            this.materialTextBox1.TabIndex = 15;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 547);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCBuscar);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtIdentidad;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox txttelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtdireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}