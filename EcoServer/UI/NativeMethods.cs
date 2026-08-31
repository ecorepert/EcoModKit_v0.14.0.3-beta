// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.NativeMethods
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using System;

#nullable disable
namespace Eco.Server.UI;

internal static class NativeMethods
{
  public static int GetScrollPosition(IntPtr hWnd, NativeMethods.ScrollbarDirection direction);

  public static void GetScrollPosition(
    IntPtr hWnd,
    out int horizontalPosition,
    out int verticalPosition);

  public static void SetScrollPosition(IntPtr hwnd, int hozizontalPosition, int verticalPosition);

  public static void SetScrollPosition(
    IntPtr hwnd,
    NativeMethods.ScrollbarDirection direction,
    int position);

  public enum ScrollbarDirection
  {
    Horizontal,
    Vertical,
  }

  private enum Messages
  {
    WM_HSCROLL = 276, // 0x00000114
    WM_VSCROLL = 277, // 0x00000115
  }
}
