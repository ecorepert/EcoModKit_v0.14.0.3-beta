// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.FuelSupplyComponentData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

/// <summary>Persists the fuel currently being burned across pickup/putdown.</summary>
[Serialized]
public class FuelSupplyComponentData : IClearRequestHandler
{
  [Serialized]
  public Item CurrentFuel { get; set; }

  [Serialized]
  public float Energy { get; set; }

  [Serialized]
  public float PeakEnergy { get; set; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);
}
