// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.TitleRequirements
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Citizens")]
[LocDescription("Detect if a citizen is a member in a set of titles.")]
[NoAutogenCode]
public class TitleRequirements : MembershipRequirements
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The titles that will be checked on the specified citizen.")]
  [AccessNotNeeded]
  public GamePickerList<Eco.Gameplay.Civics.Titles.Title> Titles { get; set; }

  protected override GamePickerList Memberships { get; }

  protected override LocString AliasNameSingular { get; }

  protected override LocString AliasNamePlural { get; }
}
