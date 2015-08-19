using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
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
        pathLabel.Text = GetMainModuleFilepath(p.Id);
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

    private string GetMainModuleFilepath(int processId)
    {
      string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + processId;
      using (var searcher = new ManagementObjectSearcher(wmiQueryString))
      {
        using (var results = searcher.Get())
        {
          ManagementObject mo = results.Cast<ManagementObject>().FirstOrDefault();
          if (mo != null)
          {
            return (string)mo["ExecutablePath"];
          }
        }
      }
      return null;
    }
  }
}
