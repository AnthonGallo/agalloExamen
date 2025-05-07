namespace agalloExamen.Views;

public partial class registro : ContentPage
{
    private string usuario;
    public registro(string usuarioRecibido)
    {
        InitializeComponent();
        usuario = usuarioRecibido;
        lblUsuarioConectado.Text = "Usuario conectado: " + usuario;
    }

    private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
    {
        double total = 300;
        double inicial = total * 0.15;
        double restante = total - inicial;
        double cuotaConInteres = (restante / 3) * 1.05;
        txtMontoInicial.Text = inicial.ToString("F2");
        txtCuotaMensual.Text = cuotaConInteres.ToString("F2");
    }


    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellido.Text) ||
            pkCiudad.SelectedIndex == -1 ||
            pkVA.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(txtMontoInicial.Text) ||
            string.IsNullOrWhiteSpace(txtCuotaMensual.Text))
        {
            DisplayAlert("Error", "Complete todos los campos antes de continuar.", "OK");
            return;
        }

        Navigation.PushAsync(new resumen(
            usuario,
            txtNombre.Text,
            txtApellido.Text,
            pkCiudad.SelectedItem.ToString(),
            dpFecha.Date,
            pkVA.SelectedItem.ToString(),
            txtMontoInicial.Text,
            txtCuotaMensual.Text
        ));
    }
}
