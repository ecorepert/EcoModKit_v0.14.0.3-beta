// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Auth.AuthManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.SharedTypes;
using Eco.Shared.Voxel;

#nullable enable
namespace Eco.Gameplay.Auth;

/// <summary> Class solely responsible for authorization about everything (e.g.: WorldObjects, Plots, GameActions, etc). </summary>
public class AuthManager : IAuthManager
{
  /// <summary> Checks authorization of a GameAction. Returns success if user is authorized on the WorldObject, if there is one, or all deeds affected if there isn't. </summary>
  /// <remarks> Also returns success if GameAction doesn't need any access, or if GameAction is NOT issued by a user (for non-user actions like <see cref="T:Eco.Gameplay.GameActions.GlobalTimer" />). </remarks>
  public LazyResult IsAuthorized(GameAction action, out AccessType actualAccessType);

  /// <summary> Checks authorization on a WorldObject. </summary>
  /// <remarks> Returns success if user is authorized on the AuthComponent, if there is one, or the plot if there isn't. </remarks>
  public LazyResult IsAuthorized(
    WorldObject obj,
    IAlias? alias,
    AccessType access,
    GameAction? action,
    out AccessType actualAccessType);

  /// <summary> Checks authorization on a position. Returns success if user is authorized on specified plot position. </summary>
  public LazyResult IsAuthorized(
    PlotPos plotPos,
    IAlias? alias,
    AccessType access,
    GameAction? action,
    out AccessType actualAccessType);

  /// <summary> Checks authorization for a swath of land (WITHOUT overrides from GameAction). </summary>
  /// <remarks> Returns success if user is authorized on ALL plots. </remarks>
  public LazyResult IsAuthorized(
    WorldRange range,
    User user,
    AccessType access,
    GameAction? action,
    out AccessType actualAccessType);

  /// <summary> Helper function to call the correct auth check given a context. </summary>
  public LazyResult IsAuthorized(
    Player player,
    InteractionTarget target,
    AccessType accessType,
    GameAction? action,
    out AccessType actualAccessType);

  /// <summary> Gets the level of authorization a user has over the specified property. <para> Internally checks for GameAction auth overrides. </para>
  /// Ignores the special result returned from overload.</summary>
  public AccessType GetAuthorizationLevel(IAlias alias, IOwned property, GameAction? action = null);

  /// <summary> Checks if auth should be overriden for target GameAction. <para> e.g.: Auth should be overriden for a GameAction that affects a WorldObject authorized by a Contract. </para> </summary>
  public LazyResult ShouldOverrideAuth(
    IAlias? alias,
    IOwned? property,
    GameAction? action,
    out AccessType actualAccessType);
}
