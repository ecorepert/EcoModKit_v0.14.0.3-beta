// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Demographics.DemographicTests
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable enable
namespace Eco.Gameplay.Civics.Demographics;

[ChatCommandHandler]
public static class DemographicTests
{
  [ChatSubCommand("Civics", "Generate some demographics.", ChatAuthorizationLevel.DevTier)]
  public static void SpawnDems(User user, int count = 5);
}
