// Decompiled with JetBrains decompiler
// Type: Eco.Server.NativeMethods
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable disable
namespace Eco.Server;

internal static class NativeMethods
{
  public const int MF_BYCOMMAND = 0;
  public const int MF_GRAYED = 1;
  public const int MF_DISABLED = 2;
  public const int SC_CLOSE = 61536;

  [DllImport("kernel32.dll")]
  public static extern IntPtr GetConsoleWindow();

  [DllImport("user32.dll")]
  public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

  [DllImport("user32.dll")]
  public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

  [DllImport("user32.dll")]
  public static extern int EnableMenuItem(IntPtr hMenu, int uIDEnableItem, int uEnable);

  [SupportedOSPlatform("linux")]
  [SupportedOSPlatform("macOS")]
  [DllImport("libc", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern int chmod(string pathname, int mode);
}
