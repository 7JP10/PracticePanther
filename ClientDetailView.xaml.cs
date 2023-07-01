using PracticePanther.Library.Models;
using PracticePanther.MAUI.ViewModels;

namespace PracticePanther.MAUI.Views;

[QueryProperty(nameof(ClientId), "clientId")]
public partial class ClientDetailView : ContentPage
{
	public ClientDetailView()
	{
        InitializeComponent();
    }

    public int ClientId { get; set; }

    //************************************************************************
    //************************************************************************
    //************************************************************************

    /*private void ManageProjectClicked(object sender, EventArgs e)
    {
        (BindingContext as ClientViewModel).RefreshProjectList();
    }*/

    /*private void AddProjectClicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync("//ClientDetail");
        //Shell.Current.GoToAsync("//ClientAdd");
        (BindingContext as ClientViewModel).RefreshProjectList();
    }*/

    private void OkClicked(object sender, EventArgs e)
    {

        //(BindingContext as ClientViewModel).Add();
        (BindingContext as ClientViewModel).Update();
        Shell.Current.GoToAsync("//Client");
    }

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Client");
    }

    //************************************************************************
    //************************************************************************
    //************************************************************************


    private void OnArriving(object sender, NavigatedToEventArgs e)
    {
        if (ClientId > 0)
        {
            //BindingContext = new ClientViewModel(ClientId);
            BindingContext = new ClientViewModel(ClientId);
            (BindingContext as ClientViewModel).RefreshProjectList();
        }
        else
        {
            Shell.Current.GoToAsync("//Client");
        }
    }

    private void OnLeaving(object sender, NavigatedToEventArgs e)
    {
        BindingContext = null;
    }

}
