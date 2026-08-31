// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Auth.RpcRateLimitAttribute
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

/// <summary>Caps RPC invocation rate per caller. Cheaters trying to spam a sensitive RPC (rep grants, item moves,
/// economic actions) hit this before the body runs. Apply alongside <c>[RPC(AccessType.ConsumerAccess)]</c>.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public sealed class RpcRateLimitAttribute : ExtraRPCAuthAttribute
{
  public RpcRateLimitAttribute(double perSecond);

  public override bool IsAuthorized(
    object target,
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);
}
