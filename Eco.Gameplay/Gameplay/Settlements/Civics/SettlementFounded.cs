// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.SettlementFounded
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Settlements.Civics;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Settlements")]
[LocDescription("A citizen founded a new settlement within the influence of another.")]
[CannotBePrevented]
public class SettlementFounded : InteractAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The type of new settlement being created.")]
  [RequiredTag("Settlement")]
  public Item SettlementType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The founded settlement.")]
  public Settlement Settlement { get; set; }
}
