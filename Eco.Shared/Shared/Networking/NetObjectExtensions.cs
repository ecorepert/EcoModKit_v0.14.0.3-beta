// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetObjectExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Shared.Networking;

public static class NetObjectExtensions
{
  public static void RPC(this INetObject netObj, string method, params object[] args);

  public static void RPC(
    this INetObject netObj,
    string method,
    INetClient target,
    params object[] args);

  public static void RPC(
    this INetObject netObj,
    string method,
    Action callback,
    params object[] args);

  public static void RPC(
    this INetObject netObj,
    string method,
    INetClient target,
    Action callback,
    params object[] args);

  public static void RPC<T>(
    this INetObject netObj,
    string method,
    Action<T> callback,
    params object[] args);

  public static void RPC<T>(
    this INetObject netObj,
    string method,
    INetClient target,
    Action<T> callback,
    params object[] args);

  public static Task<T> RPCAsync<T>(
    this INetObject netObj,
    string method,
    INetClient netClient,
    params object[] args);

  public static Task RPCAsync(
    this INetObject netObj,
    string method,
    INetClient netClient,
    params object[] args);

  public static float Priority(this INetObject netObject, INetObjectViewer viewer);
}
