namespace MauiAppHotel.Views;

public partial class HospedagemContratado : ContentPage
{
	public HospedagemContratado()
	{
		InitializeComponent();
	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}