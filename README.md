# SplashScreen.WindowsForms  
[![Nuget downloads](https://img.shields.io/nuget/v/SplashScreen.WindowsForms.svg)](https://www.nuget.org/packages/SplashScreen.WindowsForms/)
[![NuGet](https://img.shields.io/nuget/dt/SplashScreen.WindowsForms.svg)](https://github.com/zerodev1200/SplashScreen.WindowsForms)  
Library to display splash screen in Winforms.  

TargetFrameworks:.NET8,.NET6,.NetFramework4.8  
  
![SplashScreen](https://user-images.githubusercontent.com/42404360/153868303-feaa8cd1-28fd-4df6-9221-16eb4f024cd2.jpg)



### Install
```
PM> Install-Package SplashScreen.WindowsForms
```

### Getting Started



```
private void MainForm_Load(object sender, EventArgs e)
{
    var splasher = new Splasher("YourApplicationName");
    //Or
    var splasher = new Splasher("YourApplicationName","v1.0.0");
    //Or
    var splasher = new Splasher(new YourSplashForm());
    
    splasher.Show();
    
    Thread.Sleep(3000); //HeavyMethod
    
    splasher.Close();
    
    //Call Activate() because the MainForm is going backwards.
    this.Activate();
}
```

