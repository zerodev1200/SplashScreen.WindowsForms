# SplashScreen.WindowsForms
Library to display splash screen in Winforms.  

TargetFrameworks:.NET6,.NetFramework4.8  
  
  


### Getting Started



```
private void MainForm_Load(object sender, EventArgs e)
{
    var splasher = new Splasher("YourApplicationName");
    //Or
    var splasher = new Splasher(new MySplashForm());
    
    splasher.Show();
    
    Thread.Sleep(3000); //HeavyMethod
    
    splasher.Close();
    
    //Call Activate() because the MainForm is going backwards.
    this.Activate();
}
```
