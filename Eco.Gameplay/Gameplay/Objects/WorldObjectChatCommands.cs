// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WorldObjectChatCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Objects;

[ChatCommandHandler]
internal class WorldObjectChatCommands
{
  [ChatSubCommand("Objects", "Force nearest object to ignore all its requirements and always be enabled.", "fe", ChatAuthorizationLevel.Admin)]
  public static void ForceEnableNearestObject(User user, bool set = true);

  [ChatSubCommand("Objects", "Enable or disable admin interfaces across the game.", "admininterface", ChatAuthorizationLevel.Admin)]
  public static void EnableAdminInterface(User user, bool set = true);
}
