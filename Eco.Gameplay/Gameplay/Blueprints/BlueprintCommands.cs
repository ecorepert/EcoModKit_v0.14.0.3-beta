// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blueprints.BlueprintCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Gameplay.Blueprints;

/// <summary>Blueprint related commands.</summary>
[ChatCommandHandler]
public static class BlueprintCommands
{
  [ChatCommand("Blueprint testing commands.", ChatAuthorizationLevel.DevTier)]
  public static void Blueprint();

  [ChatSubCommand("Blueprint", "Generates and returns test blueprint item.", ChatAuthorizationLevel.DevTier)]
  public static void GiveTestItem(User user);
}
