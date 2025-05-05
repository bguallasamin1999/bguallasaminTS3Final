namespace bguallasaminTS3.Vista;

public partial class vista1 : ContentPage
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha { get; set; }
        public string Correo { get; set; }
        public double Salario { get; set; }
    }


    public vista1()
	{
		InitializeComponent();

    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
		string tipoIdentificacion = selIdentificacion.SelectedItem?.ToString() ?? "No selecciono tipo identificacion";
        Persona persona = new Persona
        {
            Identificacion = txtIdentificacion.Text,
            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Fecha = pickDate.Date.ToString("yyyy-MM-dd"),
            Correo = txtCorreo.Text,
            Salario = double.Parse(txtSalario.Text)
        };
        DisplayAlert("Datos", $"Tipo de identificacion: {tipoIdentificacion}\n" +
            $"Identificacion: {persona.Identificacion}\n" +
            $"Nombre: {persona.Nombre}\n" +
            $"Apellido: {persona.Apellido}\n" +
            $"Fecha: {persona.Fecha}\n" +
            $"Correo: {persona.Correo}\n" +
            $"Salario: {persona.Salario}", "OK");
        Navigation.PushAsync(new vista2(persona));
    }
}