// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTreeSim
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Tests;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Mods;

[ChatCommandHandler]
public static class TechTreeSim
{
  [CITest(false)]
  [ChatSubCommand("Craft", "Simulates the tech tree", ChatAuthorizationLevel.DevTier)]
  public static void TechTreeSimulation(
  #nullable disable
  User user);
}
