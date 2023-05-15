using AndroidX.Lifecycle;
using AppRpgEtec.ViewModels.Personagens;

namespace AppRpgEtec.Views.Personagens;

public partial class ListagemView : ContentPage
{
	public ListagemView()
	{
		InitializeComponent();

		ViewModel = new ListagemPersonagemViewModel();
		BindingContext = ViewModel;
		Title = "Personagens - App Rpg Etec";
	}
}