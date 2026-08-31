// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Civics.PlaceNewSettlementFoundation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Settlements.Civics;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Settlements")]
[LocDescription("A citizen placed a new settlement foundation within the influence of another.")]
public class PlaceNewSettlementFoundation : InteractAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The type of new settlement being created.")]
  [RequiredTag("Settlement")]
  public Item SettlementType { get; set; }
}
