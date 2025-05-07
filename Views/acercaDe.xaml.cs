namespace agalloExamen.Views;

public partial class acercaDe : ContentPage
{
    private Dictionary<string, string> usuarios = new()
    {
        { "estudiante2025", "moviles" },
        { "uisrael", "2025" },
        { "sistemas", "2025_1" }
    };

    public acercaDe(string usuario)
    {
        InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {usuario}";
        lblClave.Text = usuarios.ContainsKey(usuario)
            ? $"Contraseña: {usuarios[usuario]}"
            : "Contraseña: [No registrada]";
    }
}