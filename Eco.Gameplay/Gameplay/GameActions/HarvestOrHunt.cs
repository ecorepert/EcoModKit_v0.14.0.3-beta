// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.HarvestOrHunt
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Harvesting")]
[LocDescription("Destruction of a plant or animal, possibly yielding resources.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[ChangeParentConfigLoc("ToolUsed", null, "Harvester", null, false)]
public class HarvestOrHunt : 
  ToolInteractAction,
  ISpeciesGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  ITreeSpeciesGameAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The species of plant or animal.")]
  [Derives(typeof (Eco.Simulation.Types.Species))]
  [CanAutoAssign]
  public Type Species { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the plant or animal destroyed or damaged?")]
  public DamagedOrDestroyed DamagedOrDestroyed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the plant destroyed by block or not?")]
  public bool DestroyedByBlock { get; set; }

  [BsonIgnore]
  [ThreadSafe]
  public IEnumerable<ItemStack> HarvestedStacks { get; set; }

  [BsonIgnore]
  public int ChopperUserID { get; set; }
}
