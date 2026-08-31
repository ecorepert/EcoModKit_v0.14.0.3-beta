// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Auth.RpcGuards
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Networking;

#nullable enable
namespace Eco.Gameplay.Auth;

/// <summary>Centralized server-side guards for RPC handlers that receive untrusted IDs/targets.
/// Always derive caller identity from the auto-injected Player/User parameter (the first one);
/// use these helpers to validate any further parameters the client sent.</summary>
public static class RpcGuards
{
  /// <summary>Resolves a client-supplied netObjectID to a concrete <typeparamref name="T" /> and verifies the caller can reach the resolved target's world position with the given interact distance.
  /// Returns false (with player error message + server log) on missing object, wrong type, or out-of-range.</summary>
  public static bool TryResolveTargetInRange<T>(
    Player caller,
    int netObjectID,
    out T? target,
    float maxDistance = 0.0f)
    where T : class, INetObject;

  /// <summary>Verifies caller has the requested AccessType on the WorldObject through the deed/auth system.</summary>
  public static bool RequireDeedAuth(
    Player caller,
    WorldObject obj,
    AccessType need,
    GameAction? action = null);

  /// <summary>Verifies caller owns the target (by IOwned) or is admin.</summary>
  public static bool RequireOwnerOrAdmin(Player caller, IOwned target);

  /// <summary>Verifies caller is within interact distance of the given world position.</summary>
  public static bool RequireInteractionRange(Player caller, Vector3i position, float maxDistance = 0.0f);

  /// <summary>Verifies caller is within interact distance of the world object, measured to its nearest occupancy block so large objects are reachable from any part of their footprint.</summary>
  public static bool RequireInteractionRange(Player caller, WorldObject wo, float maxDistance = 0.0f);

  /// <summary>Verifies caller has the requested access level on <paramref name="account" /> (Use to spend, Manage to reconfigure).
  /// Used by RPC handlers that take a client-supplied BankAccount parameter — without this guard, a cheater could pass another player's account.</summary>
  public static bool RequireAccountAccess(Player caller, BankAccount? account, AccountAccess access = AccountAccess.Use);
}
