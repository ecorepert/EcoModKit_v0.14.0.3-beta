// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Channels.ChannelManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat.Channels;

/// <summary>Handles all global concerns of Channels: creation, editing, removal. Also initializes special/system channels. Is synced to each individual client via <see cref="P:Eco.Gameplay.Systems.GlobalData.Channels" />.</summary>
[Serialized]
public class ChannelManager : 
  Singleton<
  #nullable disable
  ChannelManager>,
  IRegistrarManager<Channel, SpecialChannel>,
  IRegistrarManager,
  IController,
  IViewController,
  IHasUniversalID
{
  public ThreadSafeAction OnChanged { get; }

  public Eco.Core.Systems.Registrar<Channel> Registrar { get; }

  public Channel[] SpecialEntries { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<Channel> ManagedChannels(User user);

  [SyncToView(null, true)]
  public IEnumerable<Channel> CommonChannels(User user);

  [SyncToView(null, true)]
  public IEnumerable<Channel> UsableChannels(User user);

  public static IEnumerable<Channel> Channels { get; }

  public void Initialize();

  public void InitSpecialEntry(Channel channel);

  /// <summary>Opens editor UI with a default (public) channel draft, that will be active and usable only after saving.</summary>
  [RPC]
  public void CreateChannel(Player player);

  /// <summary>Opens editor UI for the given channel.</summary>
  [RPC]
  public void EditChannel(Player player, Channel channel);

  /// <summary>When player requests to remove channel (will check permissions and popup confirm dialog)</summary>
  [RPC]
  public Task<bool> RemoveChannel(User user, Channel channel);

  /// <summary>Remove channel and all associated chat messages</summary>
  public void RemoveChannel(Channel channel);

  /// <summary>Retrieves a special channel given it's type.</summary>
  public Channel Get(SpecialChannel specialType);

  public ref int ControllerID { get; }
}
