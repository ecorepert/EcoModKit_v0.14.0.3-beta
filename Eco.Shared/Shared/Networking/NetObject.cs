// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.NetObject
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Collections;
using Eco.Shared.Serialization;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Networking;

public sealed class NetObject
{
  public INetObject Controller { get; }

  public int ID { get; }

  public bool Active { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; set; }

  /// <summary>Makes new instance of <see cref="T:Eco.Shared.Networking.NetObject" /> for <paramref name="controller" /> with <see cref="P:Eco.Shared.Networking.NetObject.Active" /> set to <paramref name="active" /> value and then <see cref="M:Eco.Shared.Networking.NetObject.Create" /> it.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static NetObject InstantiateAndCreate(INetObject controller, bool active);

  /// <summary>Makes new instance of <see cref="T:Eco.Shared.Networking.NetObject" /> for <paramref name="controller" /> with pre-defined <paramref name="id" /> and then <see cref="M:Eco.Shared.Networking.NetObject.Create" /> it.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static NetObject InstantiateAndCreate(INetObject controller, int id);

  public void Create();

  public void Destroy();

  /// <summary>
  /// Send event to multiple clients at once. It requires <see cref="T:Eco.Shared.Collections.IScopeAwareEnumerable`1" /> for <paramref name="targets" /> because may process them asynchronously and save reference to enumerable for future usage.
  /// Explicit scope control allow us to prevent errors when <paramref name="targets" /> only valid in scope of calling method and avoid defensive copy to prevent such errors when <paramref name="targets" /> safe to reference outside of scope (i.e. when they're immutable or unowned right after passing to method).
  /// </summary>
  public static void SendEvent<TScopeAwareEnumerable>(
    NetworkEvent netEvent,
    BSONObject bsonObj,
    TScopeAwareEnumerable targets,
    INetObject netObj = null)
    where TScopeAwareEnumerable : IScopeAwareEnumerable<INetClient>;

  public static void SendEvent(
    NetworkEvent netEvent,
    BSONObject bsonObj,
    INetClient target,
    INetObject netObj = null);

  /// <summary>Sends event immediately if possible ignoring previously queued messages. As side effect it makes encoding in current thread instead of network thread.</summary>
  public static void SendEventNow(NetworkEvent netEvent, BSONObject bsonObj, INetClient target);

  public static void ReceiveEvent(INetClient client, NetworkEvent netEvent, BSONValue bson);

  public static INetworkEventHandler EventHandler { set; }

  public static void ClearEventHandler();

  public static void AddNetworkInteceptor(INetworkInterceptor interceptor);

  public static bool RemoveNetworkInterceptor(INetworkInterceptor interceptor);

  public static void ClearNetworkInterceptors();
}
