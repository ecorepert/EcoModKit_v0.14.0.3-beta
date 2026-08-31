// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Auth.IAuthManager
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

public interface IAuthManager
{
  LazyResult IsAuthorized(GameAction action, out AccessType actualAccessType);

  LazyResult IsAuthorized(
    WorldObject obj,
    IAlias? alias,
    AccessType accessNeeded,
    GameAction? action,
    out AccessType actualAccessType);

  LazyResult IsAuthorized(
    PlotPos plotPos,
    IAlias? alias,
    AccessType accessNeeded,
    GameAction? action,
    out AccessType actualAccessType);

  LazyResult IsAuthorized(
    WorldRange range,
    User user,
    AccessType accessNeeded,
    GameAction? action,
    out AccessType actualAccessType);

  LazyResult IsAuthorized(
    Player player,
    InteractionTarget target,
    AccessType accessNeeded,
    GameAction? action,
    out AccessType actualAccessType);

  AccessType GetAuthorizationLevel(IAlias alias, IOwned property, GameAction? action);

  LazyResult ShouldOverrideAuth(
    IAlias? alias,
    IOwned? property,
    GameAction? action,
    out AccessType actualAccessType);
}
