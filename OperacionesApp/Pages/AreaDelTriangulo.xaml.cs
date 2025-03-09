namespace OperacionesApp.Pages;

public partial class AreaDelTriangulo : ContentPage
{
	public AreaDelTriangulo()
	{
		InitializeComponent();
	}

    private void BtnCalcularTriangulo_Clicked(object sender, EventArgs e)
    {

        if (txtBase.Text is null || txtBase.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Base esta en blanco", "Aceptar");
            txtBase.BackgroundColor = Colors.Red;
            txtBase.Focus();
        }
        else if (txtAltura.Text is null || txtAltura.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Altura esta en blanco", "Aceptar");
            txtAltura.BackgroundColor = Colors.Red;
            txtAltura.Focus();
        }
        else
        {
            double baseT = 0, altura = 0;
            double area = 0;

            baseT = Convert.ToDouble(txtBase.Text);
            altura = Convert.ToDouble(txtAltura.Text);


            area = (baseT * altura) / 2;

            txtResultado.Text = area.ToString() + "cm2"; 

        }

    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtBase.Text = "";
        txtAltura.Text = "";
        txtResultado.Text = "";
        txtBase.Focus(); 

    }
}