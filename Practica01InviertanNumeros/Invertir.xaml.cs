namespace Practica01InviertanNumeros;

public partial class Invertir : ContentPage
{
	public Invertir()
	{
		InitializeComponent();
	}

    private void Resultado_Clicked(object sender, EventArgs e)
    {
		try
		{
			int Numero1 = int.Parse(Num1.Text);
            int Numero2 = int.Parse(Num2.Text);
            int Numero3 = int.Parse(Num3.Text);
            int Numero4 = int.Parse(Num4.Text);
            int[] numeros = { Numero1, Numero2, Numero3, Numero4 };
            Array.Reverse(numeros);
            Resultado.Text = $"Número invertidos:{string.Join("",numeros)}";
        }
        catch (FormatException)
        {
            Resultado.Text = "Por favor ingrese números validos";
        }
    }
}