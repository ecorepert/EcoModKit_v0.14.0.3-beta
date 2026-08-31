// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.WorldLayerCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Chat;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[ChatCommandHandler]
public static class WorldLayerCommands
{
  [ChatSubCommand("Sim", "Regenerates a world layer, restoring it to the state it would be in if the world were newly generated.", ChatAuthorizationLevel.Admin)]
  public static void RegenLayer(IChatClient chatClient, string layerName);

  [ChatSubCommand("Sim", "Sets a world layer to specific value or random value from range.", ChatAuthorizationLevel.Admin)]
  public static void SetLayer(
    IChatClient chatClient,
    string layerName,
    float value,
    float maxValue = float.NaN);
}
