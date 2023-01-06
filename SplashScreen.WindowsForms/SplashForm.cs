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
        AppVersionLabel.Text = (string)Tag;
    }

    private void AppExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Environment.Exit(0);
    }
}
