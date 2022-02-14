namespace SplashScreen.WindowsForms;
/// <summary>
/// Class for displaying a splash form
/// </summary>
public class Splasher
{
    private readonly Form _splashForm;
    /// <summary>
    /// Your application name.
    /// </summary>
    public string AppName { get => _splashForm.Name; set => _splashForm.Name = value; }

    /// <summary>
    /// Display the ApplicationName in the normal splash form.
    /// </summary>
    /// <param name="appName"></param>
    public Splasher(string appName)
    {
        _splashForm = new SplashForm();
        _splashForm.Name = appName;
    }

    /// <summary>
    /// Displays the form you created.
    /// </summary>
    /// <param name="yourSplashForm"></param>
    public Splasher(Form yourSplashForm)
    {
        _splashForm = yourSplashForm;
    }

    /// <summary>
    /// Display the splash form in a another thread.
    /// </summary>
    public void Show()
    {
        Task.Run(() => { Application.Run(_splashForm); });
    }

    /// <summary>
    /// Close the splash form. Note: Activate() your form after this method!
    /// </summary>
    public void Close()
    {
        if (_splashForm.InvokeRequired)
            _splashForm.Invoke(() => _splashForm.Close());
        else
            _splashForm.Close();
    }
}
