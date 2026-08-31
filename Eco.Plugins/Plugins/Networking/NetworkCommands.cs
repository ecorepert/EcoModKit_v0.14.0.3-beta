// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.NetworkCommands
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Networking;

[ChatCommandHandler]
public static class NetworkCommands
{
  [ChatCommand("List of different network commands", ChatAuthorizationLevel.Admin)]
  public static void Network(
  #nullable disable
  IChatClient client);

  [ChatSubCommand("Network", "Sets the current server password", ChatAuthorizationLevel.Admin)]
  public static Task SetPassword(IChatClient client, string password = "");
}
