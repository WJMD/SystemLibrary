namespace SystemLibrary
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbLogin = new Label();
            lbCorreo = new Label();
            LkRegistrar = new LinkLabel();
            btnLogin = new Button();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            lbClave = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // LbLogin
            // 
            LbLogin.AutoSize = true;
            LbLogin.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbLogin.Location = new Point(134, 74);
            LbLogin.Name = "LbLogin";
            LbLogin.Size = new Size(118, 43);
            LbLogin.TabIndex = 0;
            LbLogin.Text = "Login";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbCorreo.Location = new Point(47, 182);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(75, 24);
            lbCorreo.TabIndex = 1;
            lbCorreo.Text = "Correo";
            // 
            // LkRegistrar
            // 
            LkRegistrar.AutoSize = true;
            LkRegistrar.Font = new Font("Arial", 12F, FontStyle.Bold);
            LkRegistrar.Location = new Point(155, 431);
            LkRegistrar.Name = "LkRegistrar";
            LkRegistrar.Size = new Size(97, 24);
            LkRegistrar.TabIndex = 3;
            LkRegistrar.TabStop = true;
            LkRegistrar.Text = "Registrar";
            LkRegistrar.LinkClicked += LkRegistrar_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(47, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(47, 209);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(301, 30);
            txtCorreo.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(47, 295);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(301, 30);
            txtClave.TabIndex = 8;
            // 
            // lbClave
            // 
            lbClave.AutoSize = true;
            lbClave.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbClave.Location = new Point(47, 268);
            lbClave.Name = "lbClave";
            lbClave.Size = new Size(62, 24);
            lbClave.TabIndex = 7;
            lbClave.Text = "Clave";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(220, 355);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 36);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 570);
            Controls.Add(btnCerrar);
            Controls.Add(txtClave);
            Controls.Add(lbClave);
            Controls.Add(txtCorreo);
            Controls.Add(btnLogin);
            Controls.Add(LkRegistrar);
            Controls.Add(lbCorreo);
            Controls.Add(LbLogin);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbLogin;
        private Label lbCorreo;
        private LinkLabel LkRegistrar;
        private Button btnLogin;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Label lbClave;
        private Button btnCerrar;
    }
}
