﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_of_Currently_Active_Application
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      timer.Start();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      try
      {
        var p = GetActiveProcess();
        textLabel.Text = p.MainWindowTitle;
        pathLabel.Text = p.MainModule.FileName;
      }
      catch (Exception)
      {
      }
    }

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint processID);

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();

    private Process GetActiveProcess()
    {
      IntPtr hwnd = GetForegroundWindow();
      uint pid;
      GetWindowThreadProcessId(hwnd, out pid);
      return Process.GetProcessById((int)pid);
    }
  }
}