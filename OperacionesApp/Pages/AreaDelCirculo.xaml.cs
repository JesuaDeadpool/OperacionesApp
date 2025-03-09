namespace OperacionesApp.Pages;

public partial class AreaDelCirculo : ContentPage
{
	public AreaDelCirculo()
	{
		InitializeComponent();
	}

    private void btnCalCir_Clicked(object sender, EventArgs e)
    {
        if (txtRadio.Text is null || txtRadio.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Radio esta en blanco", "Aceptar");
            txtRadio.BackgroundColor = Colors.Red;
            txtRadio.Focus();
        }
        else
        {
            double radio = 0;
            double area = 0;

            radio = Convert.ToDouble(txtRadio.Text);

            area = Math.PI * Math.Pow(radio, 2);

            txtResultado.Text = area.ToString() + "cm2"; 
        }

    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtRadio.Text = "";
        txtResultado.Text = "";
        txtRadio.Focus(); 
    }
}