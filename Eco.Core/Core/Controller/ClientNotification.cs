// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ClientNotification
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Core.Controller;

/// <summary> This is used to notify several clients at same time. It saves shared value which will be converted to network packet and send to all of Related Clients via broadcasting. </summary>
public struct ClientNotification
{
  public BSONObject Value;
  public IMvcNetClient? RelatedClient;
  public IMvcNetClient[]? RelatedClients;
  /// <summary> This property allows to select how the property update should be sent in reliable way (TCP-like) either on main channel or on extra one or to send it in not reliable way (UDP-like).
  /// UDP is much faster since it dont need the confirmation of client but you have no guarantee that client will get that update (packet can be lost).
  /// To be used when there are a lot of constantly modifying values at the property and it doesnt matter if client will get all of them. By example, client should carry only about last received position of object, not all of them.
  /// Another useful option - ExtraChannel. This will allow to send the notification in a separate but reliable channel, avoiding blocking general network channel so clients can still opearte while downloading something here.
  /// </summary>
  public NetworkChannel NetworkChannel;

  public ClientNotification(
    BSONObject value,
    IMvcNetClient[] clients,
    NetworkChannel notificationChannel);

  public ClientNotification(
    BSONObject value,
    IMvcNetClient client,
    NetworkChannel notificationChannel);
}
