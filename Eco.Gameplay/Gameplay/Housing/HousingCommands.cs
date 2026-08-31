// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.HousingCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Housing;

[ChatCommandHandler]
public class HousingCommands
{
  [ChatCommand("Shows commands for a variety of housing operations.", ChatAuthorizationLevel.DevTier)]
  public static void Housing(User user);

  [ChatSubCommand("Housing", "Add a number of residents to the deed you're currently a resident on.", "shackup", ChatAuthorizationLevel.DevTier)]
  public static void AddRoommates(User user, int count = 1);
}
