namespace SplashScreen.WindowsForms;
internal partial class SplashForm : Form
{
    internal SplashForm()
    {
        InitializeComponent();
    }

    private void SplashForm_Load(object sender, EventArgs e)
    {
        AppNameLabel.Text = Name;
    }

    private void AppExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Environment.Exit(0);
    }
}
