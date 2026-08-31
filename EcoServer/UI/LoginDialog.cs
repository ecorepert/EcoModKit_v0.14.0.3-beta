// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.LoginDialog
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using System.Windows.Forms;

#nullable disable
namespace Eco.Server.UI;

public class LoginDialog : Form
{
  public string UsernameText { get; set; }

  public string PasswordText { get; set; }

  protected override void Dispose(bool disposing);
}
