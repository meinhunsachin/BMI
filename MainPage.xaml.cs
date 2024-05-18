namespace BMIDemo;

public partial class MainPage : ContentPage
{
    const double UnderweigthThreshold = 18.5;
    const double NormalWeigthThreshold = 24.9;
    const double OverweigthThreshold = 29.9;
public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var weigth = double.Parse(Weigth.Text);
        var heigth = double.Parse(Heigth.Text) / 100;

        var imc = weigth / (heigth * heigth);

        BMI.Text = imc.ToString("F2");

        string result = GetBmiResultMessage(imc);
        DisplayAlert("Result", result, "Ok");
    }
    private string GetBmiResultMessage(double imc)
    {
        if(imc < UnderweigthThreshold)
        {
            return "You have Low weight";
        }
        else if(imc <= NormalWeigthThreshold)
        {
            return "Your weight is normal";
        }
        else if(imc <= OverweigthThreshold) 
        {

            return "you are Overwigth";
        }
        else
        {
            return "You have obesity , take care of yourself";
        }
    }
}