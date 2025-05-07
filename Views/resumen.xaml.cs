namespace agalloExamen.Views;

public partial class resumen : ContentPage
{
    public string Usuario { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string VA { get; set; }
    public string Fecha { get; set; }
    public string Ciudad { get; set; }
    public string Inicial { get; set; }
    public string Cuota { get; set; }
    public string PagoTotal => (double.Parse(Cuota) * 3 + double.Parse(Inicial)).ToString("F2");

    public resumen(string usuario, string nombre, string apellido, string va, DateTime fecha, string ciudad, string inicial, string cuota)
    {
        InitializeComponent();
        Usuario = usuario;
        Nombre = nombre;
        Apellido = apellido;
        VA = va;
        Fecha = fecha.ToShortDateString();
        Ciudad = ciudad;
        Inicial = inicial;
        Cuota = cuota;
        BindingContext = this;
    }

    private async void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}