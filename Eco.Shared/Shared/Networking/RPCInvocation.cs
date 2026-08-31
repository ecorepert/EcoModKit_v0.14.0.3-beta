// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RPCInvocation
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Networking;

/// <summary>
/// Contains information about <see cref="T:Eco.Shared.Networking.RPCMethod" /> invocation including method itself, target and prepared args.
/// Used as prepared call for <see cref="T:Eco.Shared.Networking.RPCManager" /> internally and also may be used externally if you need to do some kind of postprocessing/security checks on invocation.
/// </summary>
public struct RPCInvocation : IDisposable
{
  /// <summary>Max number of RPC arguments supported by argument array pool.</summary>
  private const int MaxRPCArgsCount = 9;
  /// <summary>Pool of arrays used to store arguments when invoking RPCs.</summary>
  private static readonly Queue<object[]>[] ArgPool;
  private object[]? args;
  public readonly RPCMethod Method;
  public readonly object Target;

  public Span<object> Args { get; }

  public bool IsCreated { get; }

  /// <summary>Creates <see cref="T:Eco.Shared.Networking.RPCInvocation" /> from method and target with null args. These args may be then set to required values with <see cref="P:Eco.Shared.Networking.RPCInvocation.Args" /> span accessor.</summary>
  public RPCInvocation(RPCMethod method, object target, int argsCount);

  /// <summary>Checks if <paramref name="client" /> has required access to make the invocation.</summary>
  public bool IsAuthorized(INetClient client);

  /// <summary>Performs the call.</summary>
  public readonly object? Invoke();

  /// <summary>Returns rented args array back to the pool (for reusing arrays and reducing memory allocations).</summary>
  public void Dispose();
}
