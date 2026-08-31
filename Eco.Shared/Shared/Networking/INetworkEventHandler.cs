// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.INetworkEventHandler
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Collections;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Networking;

public interface INetworkEventHandler
{
  /// <summary>Sends network event to destination target with respect to order of previously queued events.</summary>
  void SendEvent(NetworkEvent netEvent, BSONValue data, INetClient target, INetObject netObj);

  /// <summary>
  /// Send event to multiple clients at once. It requires <see cref="T:Eco.Shared.Collections.IScopeAwareEnumerable`1" /> for <paramref name="targets" /> because may process them asynchronously and save reference to enumerable for future usage.
  /// Explicit scope control allow us to prevent errors when <paramref name="targets" /> only valid in scope of calling method and avoid defensive copy to prevent such errors when <paramref name="targets" /> safe to reference outside of scope (i.e. when they're immutable or unowned right after passing to method).
  /// </summary>
  void SendEvent<TScopeAwareEnumerable>(
    NetworkEvent netEvent,
    BSONValue data,
    TScopeAwareEnumerable targets,
    INetObject netObj)
    where TScopeAwareEnumerable : IScopeAwareEnumerable<INetClient>;

  /// <summary>Sends network event immediately if possible ignoring previously queued events. If not possible then fallback to SendEvent behavior. It also makes all encoding and serialization in current thread.</summary>
  void SendEventNow(NetworkEvent netEvent, BSONValue data, INetClient target);

  void ReceiveEvent(INetClient client, NetworkEvent netEvent, BSONValue bson);
}
