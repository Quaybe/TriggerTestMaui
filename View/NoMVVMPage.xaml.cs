namespace TriggerTestMaui.View;

public partial class NoMVVMPage : ContentPage
{
	public NoMVVMPage()
	{
		InitializeComponent();
        int1Label.Text = int1.ToString();
        int1_2Label.Text = int1.ToString();
        int2Label.Text = int2.ToString();
		int2_2Label.Text = int2.ToString();
    }

    int int1 = 0;
    int int2 = 2;

    void IncrementInt(object sender, EventArgs e)
	{
		int1++;
		int1Label.Text = int1.ToString();
		int1_2Label.Text = int1.ToString();
	}
	void DecrementInt(object sender, EventArgs e)
	{
        int1--;
        int1Label.Text = int1.ToString();
        int1_2Label.Text = int1.ToString();
    }
	void Reset(object sender, EventArgs e)
	{
        int1 = 0;
        int1Label.Text = int1.ToString();
        int1_2Label.Text = int1.ToString();
    }
}