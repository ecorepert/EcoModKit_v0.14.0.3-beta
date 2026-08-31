// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.BiomeRestrictionsManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public sealed class BiomeRestrictionsManager : 
  Singleton<BiomeRestrictionsManager>,
  IController,
  IViewController,
  IHasUniversalID
{
  /// <summary>Called from the client whenever player runs out of calories while swimming.
  /// Server re-derivesthe "drowning" condition (in water + out of calories) rather than trusting the client to
  /// only call this RPC when appropriate. Without this check, a modded client could use this as a free panic-teleport
  /// at any time. The drown rules themselves are NOT changed — same calorie threshold, same difficulty gate.</summary>
  [RPC]
  public bool TeleportToClosestLand(User user);

  /// <summary>Called whenever player moves tiles to check if new tile is in a separate biome and apply biome specific modifiers</summary>
  public void CheckBiomeChanges(User user);

  public ref int ControllerID { get; }
}
