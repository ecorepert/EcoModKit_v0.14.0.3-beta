// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LawTests
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Civics.Laws;

[ChatCommandHandler]
public static class LawTests
{
  [ChatSubCommand("Civics", "Generate some test laws.", ChatAuthorizationLevel.DevTier)]
  public static void SpawnLaws(User user, Settlement settlement, int count = 5);
}
