// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.RegistrarChatCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;

#nullable enable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public class RegistrarChatCommands
{
  [ChatCommand("Shows commands allowing to list, add, remove, and clear many things in the game (including laws, titles, elections, bank accounts, and many more). Ex: /objects remove laws, Law 1")]
  public static void Objects(
  #nullable disable
  IChatClient client);

  [ChatSubCommand("Objects", "Open a display to edit any registrar object, or limit to a given type.", "edit", ChatAuthorizationLevel.Admin)]
  public static void Edit(User user, string objectType = "");

  [ChatSubCommand("Objects", "Removes objects of a given type.", ChatAuthorizationLevel.Admin)]
  public static void Clear(
    IChatClient client,
    string typeName = null,
    bool removeActive = true,
    bool removeInactive = false);

  [ChatSubCommand("Objects", "List all objects of the given type, or 'all types' if left blank.", ChatAuthorizationLevel.User)]
  public static void List(IChatClient client, string typeName = null);

  [ChatSubCommand("Objects", "Add an object of the give type.", ChatAuthorizationLevel.Admin)]
  public static void Add(User user, string typeName = null);

  [ChatSubCommand("Objects", "Edit a specific object of a given type. Can specify by name or ID.", ChatAuthorizationLevel.Admin)]
  public static void EditObj(User user, string typeName = null, string partialObjectNameOrId = null);

  [ChatSubCommand("Objects", "Edit the object with the specified ID", ChatAuthorizationLevel.Admin)]
  public static void EditById(User user, int id = -1);

  [ChatSubCommand("Objects", "Remove a specific object.  Can specify by name or ID.", ChatAuthorizationLevel.Admin)]
  public static void Remove(IChatClient client, string typeName = null, string objectNameOrId = null);

  [ChatSubCommand("Objects", "Remove the object with the specified ID", ChatAuthorizationLevel.Admin)]
  public static void RemoveById(IChatClient client, int id = -1);
}
