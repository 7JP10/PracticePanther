using PracticePanther.Library.Models;
using PracticePanther.MAUI.ViewModels;

namespace PracticePanther.MAUI.Views;

//[QueryProperty(nameof(ClientId), "clientId")]
public partial class ViewClientView : ContentPage
{
	public ViewClientView()
	{
		InitializeComponent();
        BindingContext = new ClientViewModel(1);
    }

    public int ClientId { get; set; }

    //************************************************************************
    //************************************************************************
    //************************************************************************

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Client");
    }

    //************************************************************************
    //************************************************************************
    //************************************************************************


    private void OnArriving(object sender, NavigatedToEventArgs e)
    {
        //BindingContext = new ClientViewModel(ClientId);
        (BindingContext as ClientViewModel).RefreshProjectList();
    }

    private void OnLeaving(object sender, NavigatedToEventArgs e)
    {
        BindingContext = null;
    }
}
