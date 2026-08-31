// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.ModEntryControl
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Eco.ModKit.Internal;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable enable
namespace Eco.ModKit;

public class ModEntryControl : UserControl
{
  public ModEntryControl(
  #nullable disable
  Mod mod);

  public void ToggleSubscribe();

  public Task DownloadOrInstallAsync();

  public void Uninstall();

  public Task InstallAsync();

  public Task DownloadAsync();

  /// <summary>Clean up any resources being used.</summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing);
}
