using Negocio.Personas;
using Programacion_Login.negocio;
using System.Security.Cryptography;
using System.Text;

namespace Programacion_Login
{
    public partial class frmLogin : Form
    {
        private bool EstadoLogin;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        public bool VerificarLogin
        {
            get { return EstadoLogin; }
            set { EstadoLogin = value; }
        }





        private void button1_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            Usuario usr = new Usuario(txt_user.Text, txt_pass.Text);
            try
            {
                if (login.Verificar(usr).Item1)
                {
                    bool estadoLogin = login.Verificar(usr).Item1;
                    int idPermiso = login.Verificar(usr).Item2;
                    int idUsuario = login.Verificar(usr).Item3;


                    frmMenu frmPrincipal = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
                    frmPrincipal.CargarDatos(estadoLogin, idPermiso, idUsuario);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ocultar_Click(object sender, EventArgs e)
        {
            btn_Mostrar.BringToFront();
            txt_pass.PasswordChar = '*';

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            btn_Ocultar.BringToFront();
            txt_pass.PasswordChar = '\0';

        }




        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbl_sincuenta_Click(object sender, EventArgs e)
        {

        }
    }



}
