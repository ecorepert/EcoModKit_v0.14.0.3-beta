// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ChopTree
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using Eco.Simulation.Types;
using LiteDB;
using System;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Harvesting")]
[LocDescription("A citizen chopped a tree.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[ChangeParentConfigLoc("ToolUsed", null, "Logging", null, false)]
public class ChopTree : 
  ToolInteractAction,
  ITreeSpeciesGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IConditionalStatistics
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Tree is already on ground.")]
  public bool OnGround { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the tree felled?")]
  public bool Felled { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The species of the tree.")]
  [Derives(typeof (TreeSpecies))]
  public Type Species { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Were the branches targeted?")]
  public bool BranchesTargeted { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("A value of 100 represents a fully grown tree, 0 represents a newly-planted seed.")]
  public float GrowthPercent { get; set; }

  [BsonIgnore]
  public int ChopperUserID { get; set; }

  public bool ShouldRecord();
}
