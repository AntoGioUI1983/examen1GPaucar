namespace examen1GPaucar.Vistas
{
    public partial class vLogin : ContentPage
    {
        
        string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante2024" };
        string[] contrasenas = { "uisrael2024", "parcial1", "2024" };

        public vLogin()
        {
            InitializeComponent();
        }

        private void btnInicio_Clicked_1(object sender, EventArgs e)
        {
            string usuarioInput = txtUsuario.Text;
            string contrasenaInput = txtContrasena.Text;

            bool credencialesValidas = false;
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] == usuarioInput && contrasenas[i] == contrasenaInput)
                {
                    credencialesValidas = true;
                    break;
                }
            }

            if (credencialesValidas)
            {
                Navigation.PushAsync(new vPagina(usuarioInput));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }
    }
}
