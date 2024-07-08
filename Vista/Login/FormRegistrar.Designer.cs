namespace SystemLibrary.Vista.Login
{
    partial class FormRegistrar
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
            LbRegistrar = new Label();
            txtClave = new TextBox();
            lbClave = new Label();
            lbCorreo = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtDocumento = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            txtConfimClave = new TextBox();
            label4 = new Label();
            btnCerrar = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // LbRegistrar
            // 
            LbRegistrar.AutoSize = true;
            LbRegistrar.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbRegistrar.Location = new Point(32, 30);
            LbRegistrar.Name = "LbRegistrar";
            LbRegistrar.Size = new Size(188, 43);
            LbRegistrar.TabIndex = 1;
            LbRegistrar.Text = "Registrar";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(56, 378);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(301, 30);
            txtClave.TabIndex = 4;
            // 
            // lbClave
            // 
            lbClave.AutoSize = true;
            lbClave.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbClave.Location = new Point(56, 351);
            lbClave.Name = "lbClave";
            lbClave.Size = new Size(62, 24);
            lbClave.TabIndex = 11;
            lbClave.Text = "Clave";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbCorreo.Location = new Point(56, 265);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(75, 24);
            lbCorreo.TabIndex = 9;
            lbCorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(56, 211);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 30);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 184);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.White;
            txtDocumento.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(56, 125);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "   123-4567890-1";
            txtDocumento.Size = new Size(240, 28);
            txtDocumento.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 98);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 13;
            label2.Text = "Documento";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(56, 292);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = " tucorreo@example.com";
            txtCorreo.Size = new Size(301, 30);
            txtCorreo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(349, 184);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 17;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(349, 211);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(262, 30);
            txtApellido.TabIndex = 2;
            // 
            // txtConfimClave
            // 
            txtConfimClave.BackColor = Color.White;
            txtConfimClave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfimClave.Location = new Point(56, 460);
            txtConfimClave.Name = "txtConfimClave";
            txtConfimClave.PasswordChar = '*';
            txtConfimClave.Size = new Size(301, 30);
            txtConfimClave.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(56, 433);
            label4.Name = "label4";
            label4.Size = new Size(154, 24);
            label4.TabIndex = 19;
            label4.Text = "Confirma Clave";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(326, 517);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 36);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(153, 517);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 36);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 688);
            Controls.Add(btnCerrar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtConfimClave);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtDocumento);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(lbClave);
            Controls.Add(txtCorreo);
            Controls.Add(lbCorreo);
            Controls.Add(LbRegistrar);
            Name = "FormRegistrar";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbRegistrar;
        private TextBox txtClave;
        private Label lbClave;
        private Label lbCorreo;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtDocumento;
        private Label label2;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtApellido;
        private TextBox txtConfimClave;
        private Label label4;
        private Button btnCerrar;
        private Button btnRegistrar;
    }
}