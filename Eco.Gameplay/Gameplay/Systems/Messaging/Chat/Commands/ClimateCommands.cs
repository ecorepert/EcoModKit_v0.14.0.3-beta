// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.ClimateCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Chat;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public static class ClimateCommands
{
  [ChatCommand("Shows commands for climate information.", ChatAuthorizationLevel.User)]
  public static void Climate();

  [ChatSubCommand("Climate", "Shows current climate status including CO2 levels, temperature, and sea level.", "cli", ChatAuthorizationLevel.User)]
  public static void Status(IChatClient client);
}
