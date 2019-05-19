namespace AplicadaProyectoFinal
{
    partial class RegistroUsuario
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
            this.components = new System.ComponentModel.Container();
            this.UsuarioID = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NivelUsuarioLabel = new System.Windows.Forms.Label();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.FechaIngresoLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.NivelcomboBox = new System.Windows.Forms.ComboBox();
            this.IngresodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClavenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Editarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioID
            // 
            this.UsuarioID.AutoSize = true;
            this.UsuarioID.Location = new System.Drawing.Point(13, 28);
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.Size = new System.Drawing.Size(18, 13);
            this.UsuarioID.TabIndex = 0;
            this.UsuarioID.Text = "ID";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(13, 60);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(49, 13);
            this.NombresLabel.TabIndex = 1;
            this.NombresLabel.Text = "Nombres";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 94);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // NivelUsuarioLabel
            // 
            this.NivelUsuarioLabel.AutoSize = true;
            this.NivelUsuarioLabel.Location = new System.Drawing.Point(12, 129);
            this.NivelUsuarioLabel.Name = "NivelUsuarioLabel";
            this.NivelUsuarioLabel.Size = new System.Drawing.Size(70, 13);
            this.NivelUsuarioLabel.TabIndex = 3;
            this.NivelUsuarioLabel.Text = "Nivel Usuario";
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Location = new System.Drawing.Point(13, 161);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.UsuarioLabel.TabIndex = 4;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // FechaIngresoLabel
            // 
            this.FechaIngresoLabel.AutoSize = true;
            this.FechaIngresoLabel.Location = new System.Drawing.Point(13, 193);
            this.FechaIngresoLabel.Name = "FechaIngresoLabel";
            this.FechaIngresoLabel.Size = new System.Drawing.Size(75, 13);
            this.FechaIngresoLabel.TabIndex = 5;
            this.FechaIngresoLabel.Text = "Fecha Ingreso";
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(13, 225);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(34, 13);
            this.ClaveLabel.TabIndex = 6;
            this.ClaveLabel.Text = "Clave";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(133, 28);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.IDnumericUpDown.TabIndex = 7;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(133, 60);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(196, 20);
            this.NombrestextBox.TabIndex = 8;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(133, 94);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(196, 20);
            this.EmailtextBox.TabIndex = 9;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(133, 161);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(196, 20);
            this.UsuariotextBox.TabIndex = 10;
            // 
            // NivelcomboBox
            // 
            this.NivelcomboBox.FormattingEnabled = true;
            this.NivelcomboBox.Items.AddRange(new object[] {
            "Administrador/a",
            "Cajero",
            "Supervisor",
            "Operarios"});
            this.NivelcomboBox.Location = new System.Drawing.Point(133, 129);
            this.NivelcomboBox.Name = "NivelcomboBox";
            this.NivelcomboBox.Size = new System.Drawing.Size(196, 21);
            this.NivelcomboBox.TabIndex = 11;
            // 
            // IngresodateTimePicker
            // 
            this.IngresodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.IngresodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IngresodateTimePicker.Location = new System.Drawing.Point(133, 193);
            this.IngresodateTimePicker.Name = "IngresodateTimePicker";
            this.IngresodateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.IngresodateTimePicker.TabIndex = 12;
            // 
            // ClavenumericUpDown
            // 
            this.ClavenumericUpDown.Location = new System.Drawing.Point(133, 223);
            this.ClavenumericUpDown.Name = "ClavenumericUpDown";
            this.ClavenumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.ClavenumericUpDown.TabIndex = 18;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Editarbutton
            // 
            this.Editarbutton.Image = global::AplicadaProyectoFinal.Properties.Resources.documentediting_editdocuments_text_documentedi_2820_1_;
            this.Editarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Editarbutton.Location = new System.Drawing.Point(402, 265);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(75, 75);
            this.Editarbutton.TabIndex = 19;
            this.Editarbutton.Text = "Editar";
            this.Editarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::AplicadaProyectoFinal.Properties.Resources.document_delete_256_icon_icons_com_75995;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(280, 265);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 75);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::AplicadaProyectoFinal.Properties.Resources.Save_37110;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(149, 265);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 75);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::AplicadaProyectoFinal.Properties.Resources.new_page_document_16676;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 265);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 75);
            this.Nuevobutton.TabIndex = 15;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::AplicadaProyectoFinal.Properties.Resources.iconfinder_documents07_1622836_121949_1_;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(354, 28);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(97, 47);
            this.Buscarbutton.TabIndex = 14;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 385);
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.ClavenumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IngresodateTimePicker);
            this.Controls.Add(this.NivelcomboBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.FechaIngresoLabel);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.NivelUsuarioLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.UsuarioID);
            this.Name = "RegistroUsuario";
            this.Text = "RegistroUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioID;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NivelUsuarioLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label FechaIngresoLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.ComboBox NivelcomboBox;
        private System.Windows.Forms.DateTimePicker IngresodateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.NumericUpDown ClavenumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button Editarbutton;
    }
}