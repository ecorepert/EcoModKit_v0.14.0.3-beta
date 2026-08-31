// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.ClientUpdate
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>
/// Contains data for <see cref="F:Eco.Shared.Networking.NetworkEvent.ClientUpdate" /> events.
/// Every <see cref="T:Eco.Shared.Networking.ClientUpdate" /> belongs to network queue with <see cref="F:Eco.Shared.Networking.ClientUpdate.networkChannel" />.
/// Queue index defines associated <see cref="T:Eco.Shared.Networking.NetworkEvent" /> as ClientUpdate<i>Index</i> (i.e. <see cref="F:Eco.Shared.Networking.NetworkEvent.ClientUpdateGeneral" /> and <see cref="F:Eco.Shared.Networking.NetworkEvent.ClientUpdateChunks" />).
/// It has four data arrays for <see cref="F:Eco.Shared.Networking.ClientUpdate.Created" /> objects, <see cref="F:Eco.Shared.Networking.ClientUpdate.Updated" /> objects, <see cref="F:Eco.Shared.Networking.ClientUpdate.Destroyed" /> objects and <see cref="F:Eco.Shared.Networking.ClientUpdate.ViewUpdates" />.
/// They should be filled and then flushed with <see cref="M:Eco.Shared.Networking.ClientUpdate.Send(Eco.Shared.Networking.INetClient)" /> method. Only non-empty arrays sent.
/// If all arrays are empty then <see cref="M:Eco.Shared.Networking.ClientUpdate.Send(Eco.Shared.Networking.INetClient)" /> call will be ignored unless <see cref="F:Eco.Shared.Networking.ClientUpdate.ForceSend" /> is set.
/// </summary>
public class ClientUpdate
{
  public BSONArray Created;
  public BSONArray Updated;
  public BSONArray Destroyed;
  public BSONArray ViewUpdates;
  public bool ForceSend;
  public PeriodicUpdate ForceSendThrottle;

  public ClientUpdate(byte netowrkChannel);

  public void Send(INetClient client);

  /// <summary>Recycles all BSON objects held by this <see cref="T:Eco.Shared.Networking.ClientUpdate" />. Must be called when the owning client disconnects to avoid leaking pooled BSON objects.</summary>
  public void Cleanup();
}
