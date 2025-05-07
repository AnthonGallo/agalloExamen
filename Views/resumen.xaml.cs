namespace agalloExamen.Views;

public partial class resumen : ContentPage
{
    public resumen(string usuario, string nombre, string apellido,
        string ciudad, DateTime fecha, string va, string inicial, string cuota)
    {
        InitializeComponent();

        lblUsuarioConectado.Text = $"Usuario conectado: {usuario}";
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblCiudad.Text = ciudad;
        lblFecha.Text = fecha.ToString("yyyy/MM/dd");
        lblVA.Text = va;
        lblMontoInicial.Text = $"${inicial}";
        lblCuotaMensual.Text = $"${cuota}";

        // Calcular pago total
        double montoInicial = double.Parse(inicial);
        double cuotaMensual = double.Parse(cuota);
        double pagoTotal = montoInicial + (cuotaMensual * 3);
        lblPagoTotal.Text = $"${pagoTotal:F2}";
    }

    private async void BtnCerrarSesion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); // Regresa al login
    }
}