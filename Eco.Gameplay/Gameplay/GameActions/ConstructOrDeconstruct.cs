// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ConstructOrDeconstruct
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Voxel;
using LiteDB;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Construction")]
[LocDescription("A block was constructed or deconstructed (built in a form, from a hammer or otherwise).")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[ChangeParentConfigLoc("ToolUsed", null, "Construction", null, false)]
[ChangeParentConfigLoc("ItemUsed", null, "Constructable", null, false)]
public class ConstructOrDeconstruct : BlockAddRemove, IMultiPlot
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the block constructed or deconstructed?")]
  public ConstructedOrDeconstructed ConstructedOrDeconstructed { get; set; }

  [BsonIgnore]
  public 
  #nullable disable
  PlotPos[] PlotPosList { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  public ConstructOrDeconstruct();

  public ConstructOrDeconstruct(ConstructedOrDeconstructed value);
}
