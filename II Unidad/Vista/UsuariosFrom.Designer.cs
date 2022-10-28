namespace Vista
{
    partial class UsuariosFrom
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
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.CorreoLabel = new System.Windows.Forms.Label();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.RolLabel = new System.Windows.Forms.Label();
            this.EstaActivoLabel = new System.Windows.Forms.Label();
            this.EstaActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.UsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Font = new System.Drawing.Font("Fredericka the Great", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CodigoLabel.Location = new System.Drawing.Point(40, 24);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(62, 19);
            this.CodigoLabel.TabIndex = 0;
            this.CodigoLabel.Text = "Código";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Font = new System.Drawing.Font("Fredericka the Great", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodigoTextBox.Location = new System.Drawing.Point(110, 20);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(281, 23);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Font = new System.Drawing.Font("Fredericka the Great", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreTextBox.Location = new System.Drawing.Point(110, 58);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(281, 23);
            this.NombreTextBox.TabIndex = 3;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Fredericka the Great", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreLabel.Location = new System.Drawing.Point(35, 62);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(69, 19);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre";
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Enabled = false;
            this.CorreoTextBox.Font = new System.Drawing.Font("Fredericka the Great", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorreoTextBox.Location = new System.Drawing.Point(110, 135);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(281, 23);
            this.CorreoTextBox.TabIndex = 7;
            // 
            // CorreoLabel
            // 
            this.CorreoLabel.AutoSize = true;
            this.CorreoLabel.Font = new System.Drawing.Font("Fredericka the Great", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CorreoLabel.Location = new System.Drawing.Point(43, 139);
            this.CorreoLabel.Name = "CorreoLabel";
            this.CorreoLabel.Size = new System.Drawing.Size(61, 19);
            this.CorreoLabel.TabIndex = 6;
            this.CorreoLabel.Text = "Correo";
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Enabled = false;
            this.ClaveTextBox.Font = new System.Drawing.Font("Fredericka the Great", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClaveTextBox.Location = new System.Drawing.Point(110, 97);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(281, 23);
            this.ClaveTextBox.TabIndex = 5;
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Font = new System.Drawing.Font("Fredericka the Great", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClaveLabel.Location = new System.Drawing.Point(50, 101);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(51, 19);
            this.ClaveLabel.TabIndex = 4;
            this.ClaveLabel.Text = "Clave";
            // 
            // RolComboBox
            // 
            this.RolComboBox.Enabled = false;
            this.RolComboBox.Font = new System.Drawing.Font("Fredericka the Great", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolComboBox.Location = new System.Drawing.Point(110, 173);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(281, 24);
            this.RolComboBox.TabIndex = 8;
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.Font = new System.Drawing.Font("Fredericka the Great", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RolLabel.Location = new System.Drawing.Point(62, 178);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(36, 19);
            this.RolLabel.TabIndex = 9;
            this.RolLabel.Text = "Rol";
            // 
            // EstaActivoLabel
            // 
            this.EstaActivoLabel.AutoSize = true;
            this.EstaActivoLabel.Font = new System.Drawing.Font("Fredericka the Great", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EstaActivoLabel.Location = new System.Drawing.Point(5, 210);
            this.EstaActivoLabel.Name = "EstaActivoLabel";
            this.EstaActivoLabel.Size = new System.Drawing.Size(97, 19);
            this.EstaActivoLabel.TabIndex = 10;
            this.EstaActivoLabel.Text = "Esta Activo";
            // 
            // EstaActivoCheckBox
            // 
            this.EstaActivoCheckBox.AutoSize = true;
            this.EstaActivoCheckBox.Enabled = false;
            this.EstaActivoCheckBox.Font = new System.Drawing.Font("Fredericka the Great", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EstaActivoCheckBox.Location = new System.Drawing.Point(110, 214);
            this.EstaActivoCheckBox.Name = "EstaActivoCheckBox";
            this.EstaActivoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivoCheckBox.TabIndex = 11;
            this.EstaActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NuevoButton.Image = global::Vista.Properties.Resources.Nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.Location = new System.Drawing.Point(22, 239);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(103, 30);
            this.NuevoButton.TabIndex = 12;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // UsuarioDataGridView
            // 
            this.UsuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuarioDataGridView.Enabled = false;
            this.UsuarioDataGridView.Location = new System.Drawing.Point(-1, 285);
            this.UsuarioDataGridView.Name = "UsuarioDataGridView";
            this.UsuarioDataGridView.RowTemplate.Height = 25;
            this.UsuarioDataGridView.Size = new System.Drawing.Size(639, 144);
            this.UsuarioDataGridView.TabIndex = 13;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModificarButton.Image = global::Vista.Properties.Resources.Modificar1;
            this.ModificarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarButton.Location = new System.Drawing.Point(131, 239);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(124, 30);
            this.ModificarButton.TabIndex = 14;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarButton.Image = global::Vista.Properties.Resources.Guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(261, 239);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(119, 30);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarButton.Image = global::Vista.Properties.Resources.Eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.Location = new System.Drawing.Point(386, 239);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(115, 30);
            this.EliminarButton.TabIndex = 16;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelarButton.Image = global::Vista.Properties.Resources.Cancelar_2;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(507, 239);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(117, 30);
            this.CancelarButton.TabIndex = 17;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 428);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.UsuarioDataGridView);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EstaActivoCheckBox);
            this.Controls.Add(this.EstaActivoLabel);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.CorreoLabel);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.CodigoLabel);
            this.Name = "UsuariosFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosFrom";
            this.Load += new System.EventHandler(this.UsuariosFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CodigoLabel;
        private TextBox CodigoTextBox;
        private TextBox NombreTextBox;
        private Label NombreLabel;
        private TextBox CorreoTextBox;
        private Label CorreoLabel;
        private TextBox ClaveTextBox;
        private Label ClaveLabel;
        private ComboBox RolComboBox;
        private Label RolLabel;
        private Label EstaActivoLabel;
        private CheckBox EstaActivoCheckBox;
        private Button NuevoButton;
        private DataGridView UsuarioDataGridView;
        private Button ModificarButton;
        private Button GuardarButton;
        private Button EliminarButton;
        private Button CancelarButton;
        private ErrorProvider errorProvider1;
    }
}