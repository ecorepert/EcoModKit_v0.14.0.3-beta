// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.SpeciesCatchers.BoatCatcher
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Utils;
using Eco.Gameplay.Animals.Catchers.Internal;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Mods.Components.VehicleModules;
using Eco.Simulation.Types;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Mods.Organisms.SpeciesCatchers;

/// <summary> Catcher to use with  trawler vehicles with fishing nets</summary>
public class BoatCatcher : WorldObjectLayeredCatchEntry
{
  public override ThreadSafeList<string> DefaultTargetSpecies { get; }

  public override Inventory TargetInventory { get; }

  public override bool OnValidationCheck();

  public override TimeSpan NextCatchDelay { get; }

  protected override Range CatchRange { get; }

  public BoatCatcher(
    User user,
    WorldObject obj,
    VehicleComponent vehicle,
    FishingComponent fishing);

  public BoatCatcher();

  public override void Initialize(List<string> layers);

  protected override bool ApplyCatch(Species species, int amount);
}
