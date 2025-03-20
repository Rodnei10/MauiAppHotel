using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadeApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadeApp = (App)Application.Current;
		pck_quarto.ItemsSource = PropriedadeApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

		dtpck_checkin.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkin.MaximumDate = dtpck_checkin.Date.AddMonths(6);
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Hospedagem h = new Hospedagem
			{
				QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
				QntAdultos = Convert.ToInt32(stp_adultos.Value),
				QntCriancas = Convert.ToInt32(stp_criancas.Value),
				DataCheckIn = dtpck_checkin.Date,
				DataCheckout = dtpck_checkin.Date,
			};

			await Navigation.PushAsync(new Views.HospedagemContratado()
			{
				BindingContext = h
			});
		}

		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
	}

	private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
	{
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;

		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
	}
}