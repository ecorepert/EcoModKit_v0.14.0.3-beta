// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Internal.PlayerSimulation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Agents;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Gameplay.Players.Internal;

public static class PlayerSimulation
{
  internal static void SimulationInteract(
    Player player,
    INetObject interactor,
    WorldObserver.SimulationInteractType interactionType);
}
