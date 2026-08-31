// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.RPCAuthMaxProposableStateAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Auth;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

/// <summary>Marks a RPC method for <see cref="T:Eco.Gameplay.Civics.Misc.SimpleProposable" /> as allowed only for states between <see cref="P:Eco.Gameplay.Civics.Misc.RPCAuthMaxProposableStateAttribute.MinState" /> and <see cref="F:Eco.Gameplay.Civics.Misc.RPCAuthMaxProposableStateAttribute.MaxState" />. See <strong>RPCAuthorization.md</strong> for details.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
public class RPCAuthMaxProposableStateAttribute : ExtraRPCAuthAttribute
{
  public readonly ProposableState MaxState;

  public ProposableState MinState { get; init; }

  public RPCAuthMaxProposableStateAttribute(ProposableState maxState);

  public override bool IsAuthorized(
    object obj,
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);
}
