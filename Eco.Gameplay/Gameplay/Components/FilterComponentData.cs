// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.FilterComponentData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Persistent state for <see cref="T:Eco.Gameplay.Components.FilterComponent" />. Accumulators are per-output, in mils.</summary>
[Serialized]
public class FilterComponentData : IClearRequestHandler
{
  [Serialized]
  public int[] AccumulatedMilsPerOutput { get; set; }

  [Serialized]
  public CatalystState CatalystState { get; set; }

  [Serialized]
  public int SelectedInputIndex { get; set; }

  [Serialized]
  public bool RelayWhenOutOfCatalyst { get; set; }

  [Serialized]
  public FilterProfileProgress[] ParkedProfiles { get; set; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);
}
