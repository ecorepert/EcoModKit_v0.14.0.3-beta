// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.IItemConsumingComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>A component whose object eats whatever is put in these inventories — a fuel hopper burns it, a recycler shreds it.
/// Anything that delivers items into the object must leave them alone: a crafting table sharing its object with one of these would
/// otherwise hand its own products straight back to it.</summary>
public interface IItemConsumingComponent
{
  IEnumerable<Inventory> ConsumedInventories { get; }
}
