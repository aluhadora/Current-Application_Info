namespace Name_of_Currently_Active_Application
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.blahLabel = new System.Windows.Forms.Label();
      this.pathLabel = new System.Windows.Forms.Label();
      this.textLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // timer
      // 
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Window text:";
      // 
      // blahLabel
      // 
      this.blahLabel.AutoSize = true;
      this.blahLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.blahLabel.Location = new System.Drawing.Point(12, 25);
      this.blahLabel.Name = "blahLabel";
      this.blahLabel.Size = new System.Drawing.Size(50, 13);
      this.blahLabel.TabIndex = 1;
      this.blahLabel.Text = "File path:";
      // 
      // pathLabel
      // 
      this.pathLabel.AutoSize = true;
      this.pathLabel.Location = new System.Drawing.Point(87, 25);
      this.pathLabel.Name = "pathLabel";
      this.pathLabel.Size = new System.Drawing.Size(69, 13);
      this.pathLabel.TabIndex = 3;
      this.pathLabel.Text = "Window text:";
      // 
      // textLabel
      // 
      this.textLabel.AutoSize = true;
      this.textLabel.Location = new System.Drawing.Point(87, 9);
      this.textLabel.Name = "textLabel";
      this.textLabel.Size = new System.Drawing.Size(69, 13);
      this.textLabel.TabIndex = 2;
      this.textLabel.Text = "Window text:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.pathLabel);
      this.Controls.Add(this.textLabel);
      this.Controls.Add(this.blahLabel);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Active Application";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label blahLabel;
    private System.Windows.Forms.Label pathLabel;
    private System.Windows.Forms.Label textLabel;
  }
}

