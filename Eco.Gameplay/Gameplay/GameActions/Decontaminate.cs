// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.Decontaminate
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Stats;
using LiteDB;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Pollution")]
[LocDescription("A citizen applied a decontaminant to the ground.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
public class Decontaminate : ItemInteractAction
{
  [BsonIgnore]
  public override AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Units of pollution source the decontaminant will cancel, drained into the ground over the following days.")]
  [SumInAggregateGrouping]
  public float PollutionRemoved { get; set; }
}
