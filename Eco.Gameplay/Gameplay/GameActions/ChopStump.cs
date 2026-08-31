// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ChopStump
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
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
[LocDescription("A citizen chopped a stump.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
public class ChopStump : 
  InteractAction,
  ITreeSpeciesGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IToolGameAction,
  IConditionalStatistics
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The species of the tree.")]
  [Derives(typeof (TreeSpecies))]
  public Type Species { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the stump destroyed?")]
  public bool Destroyed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("What was used to chop the stump?")]
  [RequiredTag("Logging")]
  public Item ToolUsed { get; set; }

  [BsonIgnore]
  public int ChopperUserID { get; set; }

  public bool ShouldRecord();
}
