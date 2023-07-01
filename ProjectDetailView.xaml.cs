namespace PracticePanther.MAUI.Views;

using PracticePanther.Library.Models;
using PracticePanther.MAUI.ViewModels;

[QueryProperty(nameof(ProjectId), "projectId")]
public partial class ProjectDetailView : ContentPage
{
	public ProjectDetailView()
	{
		InitializeComponent();
        //BindingContext = new ProjectViewModel(projectId);
    }


    public int ProjectId { get; set; }

    //************************************************************************
    //************************************************************************
    //************************************************************************

    private void OkClicked(object sender, EventArgs e)
    {

        //(BindingContext as ClientViewModel).Update();
        //Shell.Current.GoToAsync("//Client");

        if (ProjectId > 0)
        {
            (BindingContext as ProjectViewModel).Update();
            int cId = (BindingContext as ProjectViewModel).Model.ClientId;
            Shell.Current.GoToAsync($"//ManageProject?clientId={cId}");
        }
        else
        {
            Shell.Current.GoToAsync("//Client");
        }
    }

    private void CancelClicked(object sender, EventArgs e)
    {
        if (ProjectId > 0)
        {
            int cId = (BindingContext as ProjectViewModel).Model.ClientId;
            Shell.Current.GoToAsync($"//ManageProject?clientId={cId}");
        }
        else
        {
            Shell.Current.GoToAsync("//Client");
        }
    }

    //************************************************************************
    //************************************************************************
    //************************************************************************


    private void OnArriving(object sender, NavigatedToEventArgs e)
    {
        if (ProjectId > 0)
        {
            BindingContext = new ProjectViewModel(ProjectId, true);
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
