// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicAction_ChangeSettlementName
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Civics;

/// <summary>A civic action that lets you change the name of a settlement.</summary>
[Serialized]
[AddCivicActionToObject(typeof (SettlementFoundationObject))]
[Tag("CanBeInConstitution")]
[LocDisplayName("Change Settlement Name")]
[LocDescription("Rename this settlement, and attached objects if the name still matches (demographic, leader, immigration policy, etc).")]
[RelatedFeature("UseSettlementSystem", true)]
public class CivicAction_ChangeSettlementName : SettlementCivicAction, ICustomValidity, IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [Range(3f, 50f)]
  public string? NewName { get; set; }

  public Result Valid();

  public override void Initialize(Settlement settlement);

  public override Result CanExecute(User user);

  public override LocString Description();

  public override Result Perform(User user, Election election);
}
