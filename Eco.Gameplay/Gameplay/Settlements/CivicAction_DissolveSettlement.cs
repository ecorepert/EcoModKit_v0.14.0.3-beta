// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.CivicAction_DissolveSettlement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Settlements;

[LocDisplayName("Dissolve Settlement")]
[LocDescription("Destroy the settlement and remove all citizens, influence, laws, etc.")]
[RelatedFeature("UseSettlementSystem", true)]
[Tag("CanBeInConstitution")]
[Serialized]
public class CivicAction_DissolveSettlement : SettlementCivicAction
{
  public Result Valid();

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public override LocString Description();
}
