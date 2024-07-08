using SystemLibrary.Controller;
using SystemLibrary.Model;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using SystemLibrary.Vista;
using SystemLibrary.Vista.Login;

namespace SystemLibrary
{
    public partial class FormLogin : Form
    {
        DbConexion dbConexion = new DbConexion();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Correo = txtCorreo.Text;
            string Clave = txtClave.Text;
            Model.IniciarSession iniciarSession = new Model.IniciarSession();
            iniciarSession.Login(Correo, Clave);
            /*ADM formIni = new ADM();
            formIni.Show();*/
        }

        private void LkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrar fromRegistrar = new FormRegistrar();
            fromRegistrar.ShowDialog();
        }
    }
}
