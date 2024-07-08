using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary.Model;

namespace SystemLibrary.Vista.Login
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Model.Registrar registrar = new Model.Registrar();  
            string Docuemnto = txtDocumento.Text;
            string NombreCompleto = txtNombre.Text + " " + txtApellido.Text;
            string Correo = txtCorreo.Text;
            string Clave = txtClave.Text;


           if( registrar.ValidEmpty(txtDocumento, txtNombre, txtApellido,
                txtCorreo, txtClave, txtConfimClave))
            {
                MessageBox.Show("Se guardaron los datos");
            }else
            {
                MessageBox.Show("No se guardaron los datos");
            }

           
            

        }
    }
}
