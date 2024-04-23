namespace examen1GPaucar.Vistas;

public partial class vInforme : ContentPage
{
	public vInforme(string estudiante,string apellido)
	{
		InitializeComponent();
		txtNombre.Text = estudiante;
        txtApellido.Text = apellido;
		
    }
}