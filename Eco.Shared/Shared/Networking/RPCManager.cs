// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RPCManager
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Shared.Networking;

/// <summary>Manager responsible for RPC lookup and invocation.</summary>
public class RPCManager
{
  public const 
  #nullable disable
  string QueryKey = "query";
  public static PerformanceManager RPCLogger;
  public static Action<TimeSpan> LogRPCResponseTime;

  public static IEnumerable<KeyValuePair<string, RPCMethod[]>> RPCs(Type type);

  public static object ControllerManager { get; }

  public static TaskScheduler TaskScheduler { get; set; }

  public static void SetKeyToIdMapping(BSONArray rpcInfos);

  public static int GetMethodId(string key);

  public static void CreateLookupsForDerived(Type basetype);

  public static void Call<T>(
    string methodname,
    INetObject obj,
    INetClient target,
    Action<T> resultCallback,
    params object[] args);

  public static void Call(
    string methodname,
    INetObject obj,
    INetClient target,
    Action resultCallback,
    params object[] args);

  public static void Call(
    string methodname,
    INetObject obj,
    INetClient target,
    params object[] args);

  public static void HandleQueryResponse(BSONObject bson);

  public static object InvokeOn(
    INetClient client,
    BSONObject bson,
    object target,
    string methodName);

  /// <summary>Invokes <paramref name="invocation" /> with access permissions check.</summary>
  [return: MaybeNull]
  public static object Invoke(
    [AllowNull] INetClient client,
    RPCInvocation invocation,
    bool notifyOnPermissionFail = true);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreateInvocation(
    INetClient client,
    object target,
    string methodName,
    BSONArray bsonArgs,
    out RPCInvocation invocation);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryCreateInvocation(
    INetClient client,
    object target,
    string methodName,
    IList<object> packedArgs,
    out RPCInvocation invocation);

  /// <summary>Resolves method name from method id or method name.</summary>
  public static string ResolveMethodName(string methodIdOrName);

  public static Task HandleReceiveRPC(INetClient client, BSONObject bson);

  public static bool HasRPCOnType(Type type, string name);

  public static Dictionary<string, RPCMethod[]> GetOrBuildLookup(Type type);

  /// <summary> Try creating an <see cref="T:Eco.Shared.Networking.RPCManager.AwaitedQuery" /> using the given callback and bind it to the given <see cref="T:Eco.Shared.Serialization.BSONObject" /></summary>
  public static bool TryCreateAndAddQuery<T>(
    BSONObject bson,
    Action<T> callback,
    INetClient target,
    string methodName);

  /// <summary> Try creating an <see cref="T:Eco.Shared.Networking.RPCManager.AwaitedQuery" /> using the given callback and bind it to the given <see cref="T:Eco.Shared.Serialization.BSONObject" /></summary>
  public static bool TryCreateAndAddQuery(
    BSONObject bson,
    Action callback,
    INetClient target,
    string methodName);

  public static RPCMethod GetRPC(int id);

  /// <summary> A query that is used by <see cref="T:Eco.Shared.Networking.RPCManager" /> to manage RPCs that have callbacks. </summary>
  private class AwaitedQuery
  {
    public Action<object> Callback;
    public Type ResultType;
    public INetClient Target;
    public DateTime QueryTime;
    public string MethodName;

    public bool Dead { get; }
  }
}
