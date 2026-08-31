// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Chat.UserRPCButtonTestExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Gameplay.Systems.Chat;

public static class UserRPCButtonTestExtensions
{
  [RPC]
  public static void TestLink(this User user, string text);

  [RPC]
  public static void TestLinkNoArgs(this User user);
}
