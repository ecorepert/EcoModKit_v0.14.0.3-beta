// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.MultiblockActionContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.GameActions;

/// <summary> Parameters, the presence of which will determine behavior of multi-block atomic action.
/// Default values will be ignored, i.e. if there is no fuel component provided, then nothing will be burned. </summary>
public struct MultiblockActionContext
{
  public Player? Player { get; set; }

  public AccessType? AccessNeeded { get; set; }

  public IEnumerable<Vector3i>? Area { get; set; }

  public IEnumerable<Type>? BlockTypesInArea { get; set; }

  public GameActionDescription? ActionDescription { get; set; }

  public Type? ExperienceSkill { get; set; }

  public float ExperiencePerAction { get; set; }

  public float CaloriesPerAction { get; set; }

  public RepairableItem? RepairableItem { get; set; }

  public FuelSupplyComponent? FuelComponent { get; set; }

  public float FuelPerAction { get; set; }

  public Func<GameAction>? GameActionConstructor { get; set; }

  public Item? ToolUsed { get; set; }
}
