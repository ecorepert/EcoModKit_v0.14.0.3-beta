// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Animals.Catchers.Internal.LayeredCatchEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Simulation.Types;
using Eco.Simulation.WorldLayers.Layers;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Animals.Catchers.Internal;

/// <summary>
/// Core atomic component for layered catch system.
/// Gets the species name and converts/caches that to animal world layers
/// On tick it tries to check population there and catch smth, by special configurable rules (todo implement and add them to LayeredCatchEntryConfig too)
/// It applies changes to layer afterwards
/// </summary>
public abstract class LayeredCatchEntry
{
  public static readonly TimeSpan DefaultUpdateInterval;
  public 
  #nullable disable
  User User;
  public Action NoLayerData;
  public Action<IEnumerable<LayeredCatchEntry.CatchLayerData>> TryCatch;
  public Action<Species, int> SuccessfullCatch;

  /// <summary> Default target species that will be default in configuration. Only used for initial setup. </summary>
  public virtual ThreadSafeList<string> DefaultTargetSpecies { get; set; }

  /// <summary> If this catcher is active and should be processed on regular update </summary>
  public bool Enabled { get; }

  /// <summary> Cached animal layers from Species list provided. </summary>
  public AnimalLayer[] AnimalLayers { get; }

  /// <summary> Inventory that will be used to put items gathered by this catcher </summary>
  public virtual Inventory TargetInventory { get; }

  /// <summary> Cached time interval for next tick </summary>
  public virtual TimeSpan NextCatchDelay { get; }

  /// <summary> Current catch delay tick, so we can have time randoness </summary>
  public TimeSpan CurrentCatchDelay { get; }

  /// <summary> Amount of resources per catch update (e.g.: 1..1 = min of 1 max 1, 0..2 = min of 0, max of 2) </summary>
  protected virtual System.Range CatchRange { get; }

  protected LayeredCatchEntry();

  protected LayeredCatchEntry(User user);

  protected virtual void OnCatchSuccessful(Species species, int qt);

  /// <summary> Fill new species to this catcher (useful for updates in runtime on config changes) </summary>
  public void ApplyData(List<string> speciesList);

  public virtual void Initialize(List<string> layers);

  /// <summary>
  /// Tick - Updates enabled catch entry
  /// 1. Updates catch check interval
  /// 2. Tries to apply randomized results catch to layer when interval is reached
  /// </summary>
  /// <returns></returns>
  public TimeSpan Tick();

  /// <summary> Tries to apply catch to inventory and environments changes </summary>
  protected virtual bool ApplyCatch(Species species, int amount);

  /// <summary> This should return position to check for layer catch process. For fishing pole its lure, for fishing trap its trap position, etc </summary>
  public abstract Vector3i OnPositionCheck();

  /// <summary> This should check if this catcher is still need to be processed. This is always checked before tick, and if returns false -&gt; this catcher will be removed </summary>
  public virtual bool OnValidationCheck();

  /// <summary> Structure for cached layer data for special rules to be applied on to it (on how to catch things) </summary>
  public struct CatchLayerData
  {
    public Vector2i LayerPos;
    public float LayerValue;
    public AnimalLayer Layer;

    public CatchLayerData(AnimalLayer layer, Vector2i layerPos);
  }
}
