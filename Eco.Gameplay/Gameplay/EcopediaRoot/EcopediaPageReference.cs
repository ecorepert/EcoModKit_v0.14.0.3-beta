// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.EcopediaRoot.EcopediaPageReference
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.EcopediaRoot;

public struct EcopediaPageReference
{
  public string IconName;
  public string Category;
  public string Page;
  public string Subpage;
  public LocString? PageDisplayName;
  public LocString? SubpageDisplayName;

  public EcopediaPageReference(
    string iconName,
    string category,
    string page,
    LocString pageDisplayName);

  public EcopediaPageReference(string iconName, string category, string page, string subpage);

  public EcopediaPageReference(
    string iconName,
    string category,
    string page,
    LocString? pageDisplayName,
    string subpage,
    LocString? subpageDisplayName);
}
