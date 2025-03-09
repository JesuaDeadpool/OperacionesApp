
using System.Drawing;

namespace OperacionesApp.Pages;

public partial class AreaDelCuadrado : ContentPage
{

	public AreaDelCuadrado()
	{
		InitializeComponent();
	}

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        if(txtLado.Text == "" || txtLado.Text is null)
        {
            DisplayAlert("ADVERTENCIA", "lado esta en blanco", "Aceptar");
            txtLado.BackgroundColor = Colors.Red; 
            txtLado.Focus(); 
        }
  
        else
        {
            double lado = 0;
            double resultArea = 0;

            lado = Convert.ToDouble(txtLado.Text);
            resultArea = System.Math.Pow(lado, 2);
            txtLado.BackgroundColor = Colors.Transparent;
            txtResultado.Text = resultArea.ToString() + "cm2"; 
        }
    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtLado.Text = "";
        txtResultado.Text = "";
        txtLado.Focus(); 
    }
}