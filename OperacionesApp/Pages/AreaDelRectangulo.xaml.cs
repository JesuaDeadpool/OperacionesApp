namespace OperacionesApp.Pages;

public partial class AreaDelRectangulo : ContentPage
{
	public AreaDelRectangulo()
	{
		InitializeComponent();
	}

    private void BtnCalcularRectangulo_Clicked(object sender, EventArgs e)
    {

        if (txtLargo.Text is null || txtLargo.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Largo esta en blanco", "Aceptar");
            txtLargo.BackgroundColor = Colors.Red;
            txtLargo.Focus();
        }
        else if (txtAncho.Text is null || txtAncho.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Ancho esta en blanco", "Aceptar");
            txtAncho.BackgroundColor = Colors.Red;
            txtAncho.Focus();
        }
        else
        {
            double largo = 0, ancho = 0;
            double area = 0;

            largo = Convert.ToDouble(txtLargo.Text);
            ancho = Convert.ToDouble(txtAncho.Text);


            area = largo * ancho;

            txtResultado.Text = area.ToString("F2") + "cm2";

        }
    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {

        txtLargo.Text = "";
        txtAncho.Text = "";
        txtResultado.Text = "";
        txtLargo.Focus(); 

    }
}