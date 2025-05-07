namespace agalloExamen.Views;

public partial class login : ContentPage
{
    Dictionary<string, string> users = new()
    {
        {"estudiante2025", "moviles"},
        {"uisrael", "2025"},
        {"sistemas", "2025_1"},
    };

    public login()
    {
        InitializeComponent();
    }

    private async void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (users.TryGetValue(txtUsuario.Text, out var pass) && pass == txtClave.Text)
        {
            App.UsuarioConectado = txtUsuario.Text;
            await Navigation.PushAsync(new registro());
        }
        else
        {
            await DisplayAlert("Error", "Datos incorrectos", "OK");
        }
    }

    private async void btnAcercaDe_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new acercaDe());
    }
}