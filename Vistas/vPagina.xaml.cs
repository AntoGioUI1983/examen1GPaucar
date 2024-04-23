namespace examen1GPaucar.Vistas;

public partial class vPagina : ContentPage
{
    double monto;

    double costoCurso = 3000;
    double porcentaje;
    double costoIncremento;
    double restante;
    double pagoMes;
    public vPagina(string usuario)
    {

        InitializeComponent();
        DisplayAlert("Bienvenido", usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuario;

    }




    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        monto = Convert.ToDouble(txtMonto.Text);

        porcentaje = costoCurso * 0.05;
        costoIncremento = costoCurso + porcentaje;
        restante = costoIncremento - monto;
        pagoMes = restante / 3;
        txtPagoMes.Text = pagoMes.ToString();

    }


    private void btnResumen_Clicked(object sender, EventArgs e)
    {


        Navigation.PushAsync(new vInforme(txtNombre.Text,txtApellido.Text));
    }
}
