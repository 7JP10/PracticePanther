namespace PracticePanther.MAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ClientsClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Client");
    }

    public void EmployeeClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ManageEmployee");
    }
}


