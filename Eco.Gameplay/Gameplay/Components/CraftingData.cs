// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CraftingData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
public class CraftingData : IClearRequestHandler
{
  [Serialized]
  public ThreadSafeList<CompletedGarbage> GarbageAccumulator { get; set; }

  [Serialized]
  public ThreadSafeDictionary<int, string> SelectedFilterPerUser { get; set; }

  [Serialized]
  public ThreadSafeDictionary<int, UserIngredientFilters> IngredientFiltersPerUser { get; set; }

  public int GarbageTotal { get; }

  public bool IsGarbageFull { get; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);
}
