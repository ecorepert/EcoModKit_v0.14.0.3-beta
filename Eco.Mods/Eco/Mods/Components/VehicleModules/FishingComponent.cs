// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Components.VehicleModules.FishingComponent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.Components.VehicleModules;

[Serialized]
[RequireComponent(typeof (PublicStorageComponent), "FishingStorage")]
[RequireComponent(typeof (ModularVehicleComponent), null)]
[ForceCreateView]
[NoIcon]
public class FishingComponent : WorldObjectComponent
{
  public ModularVehicleComponent VehicleMod;

  [Serialized]
  [SyncToView(null, true)]
  public PublicStorageComponent Storage { get; }

  [SyncToView(null, true)]
  public bool Fishing { get; }

  public bool CanFish { get; }

  public void Initialize(int numSlots, int maxWeight);

  [RPC]
  public void SetFishing(Player player, bool state);

  [RPC]
  public void Catch(Player player, INetObject target);
}
