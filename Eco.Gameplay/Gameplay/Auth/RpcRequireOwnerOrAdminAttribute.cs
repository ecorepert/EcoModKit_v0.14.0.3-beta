// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Auth.RpcRequireOwnerOrAdminAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Auth;
using System;

#nullable enable
namespace Eco.Gameplay.Auth;

/// <summary>Requires the caller to be an admin or to own the target (target must implement <see cref="T:Eco.Gameplay.Property.IOwned" />).
/// Pair with <c>[RPC(AccessType.ConsumerAccess)]</c> when an action should only be performed by the asset's owner.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public sealed class RpcRequireOwnerOrAdminAttribute : ExtraRPCAuthAttribute
{
  public override bool IsAuthorized(
    object target,
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);
}
