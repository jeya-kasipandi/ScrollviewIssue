using static System.Net.Mime.MediaTypeNames;

namespace ScrollViewIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        count++;
        horizontalLayout.Children.Add(new Label() { Text = "New Label" + count });

    }
   
}


