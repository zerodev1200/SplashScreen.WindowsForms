namespace SplashScreen.WindowsForms;

partial class SplashForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.AppExitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadingLabel.ForeColor = System.Drawing.Color.White;
            this.LoadingLabel.Location = new System.Drawing.Point(253, 317);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(75, 21);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AppNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppNameLabel.ForeColor = System.Drawing.Color.White;
            this.AppNameLabel.Location = new System.Drawing.Point(0, 122);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(580, 70);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.Text = "AppName";
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(179, 295);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(222, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            // 
            // AppExitLinkLabel
            // 
            this.AppExitLinkLabel.AutoSize = true;
            this.AppExitLinkLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppExitLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AppExitLinkLabel.LinkColor = System.Drawing.Color.White;
            this.AppExitLinkLabel.Location = new System.Drawing.Point(511, 26);
            this.AppExitLinkLabel.Name = "AppExitLinkLabel";
            this.AppExitLinkLabel.Size = new System.Drawing.Size(21, 25);
            this.AppExitLinkLabel.TabIndex = 3;
            this.AppExitLinkLabel.TabStop = true;
            this.AppExitLinkLabel.Text = "x";
            this.AppExitLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppExitLinkLabel_LinkClicked);
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.AppVersionLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppVersionLabel.Location = new System.Drawing.Point(0, 192);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(580, 25);
            this.AppVersionLabel.TabIndex = 4;
            this.AppVersionLabel.Text = " ";
            this.AppVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.AppExitLinkLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.AppNameLabel);
            this.Controls.Add(this.LoadingLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(580, 360);
            this.MinimumSize = new System.Drawing.Size(580, 360);
            this.Name = "SplashForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label LoadingLabel;
    private Label AppNameLabel;
    private ProgressBar progressBar1;
    private LinkLabel AppExitLinkLabel;
    private Label AppVersionLabel;
}
