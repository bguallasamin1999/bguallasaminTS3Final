namespace bguallasaminTS3.Vista;

public partial class vista2 : ContentPage
{
	private vista1.Persona personaRecibida;
	public vista2(vista1.Persona persona)
    {
        InitializeComponent();
        personaRecibida = persona;
        lblIdentificacion.Text = personaRecibida.Identificacion;
        lblNombre.Text = personaRecibida.Nombre;
        lblApellido.Text = personaRecibida.Apellido;
        lblFecha.Text = personaRecibida.Fecha;
        lblCorreo.Text = personaRecibida.Correo;
        lblSalario.Text = personaRecibida.Salario.ToString("C", System.Globalization.CultureInfo.CurrentCulture);

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        var carpetaEscritorio = Path.Combine(escritorio, "archivo");

        // Crear la carpeta si no existe
        if (!Directory.Exists(carpetaEscritorio))
        {
            Directory.CreateDirectory(carpetaEscritorio);
        }

        // Usar StreamWriter para escribir en el archivo
        var rutaArchivo = Path.Combine(carpetaEscritorio, "persona.txt");

        try
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine($"Identificacion: {personaRecibida.Identificacion}");
                writer.WriteLine($"Nombre: {personaRecibida.Nombre}");
                writer.WriteLine($"Apellido: {personaRecibida.Apellido}");
                writer.WriteLine($"Fecha: {personaRecibida.Fecha}");
                writer.WriteLine($"Correo: {personaRecibida.Correo}");
                writer.WriteLine($"Salario: {personaRecibida.Salario}");
            }
            DisplayAlert("Éxito", "Archivo creado exitosamente", "OK");
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"Error al crear el archivo: {ex.Message}", "OK");
        }

    }

}