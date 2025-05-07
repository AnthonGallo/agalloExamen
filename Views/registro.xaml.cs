namespace agalloExamen.Views;

public partial class registro : ContentPage
{
    public registro()
    {
        InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {App.UsuarioConectado}";

        pickerVA.Items.Add("500");
        pickerVA.Items.Add("750");
        pickerVA.Items.Add("1000");

        pickerCiudad.Items.Add("Quito");
        pickerCiudad.Items.Add("Guayaquil");
        pickerCiudad.Items.Add("Cuenca");
    }

    private async void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellido.Text) ||
            pickerVA.SelectedItem == null ||
            pickerCiudad.SelectedItem == null ||
            string.IsNullOrWhiteSpace(txtInicial.Text) ||
            string.IsNullOrWhiteSpace(txtCuota.Text))
        {
            await DisplayAlert("Error", "Debe llenar todos los campos y seleccionar VA y Ciudad.", "OK");
            return;
        }

        string va = pickerVA.SelectedItem?.ToString() ?? "";
        string ciudad = pickerCiudad.SelectedItem?.ToString() ?? "";

        await Navigation.PushAsync(new resumen(
            App.UsuarioConectado,
            txtNombre.Text,
            txtApellido.Text,
            va,
            fecha.Date,
            ciudad,
            txtInicial.Text,
            txtCuota.Text
        ));
    }

    private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
    {
        double precio = 300;
        double inicial = precio * 0.15;
        double cuota = (precio * 0.85 / 3) * 1.05;
        txtInicial.Text = inicial.ToString("F2");
        txtCuota.Text = cuota.ToString("F2");
    }
}