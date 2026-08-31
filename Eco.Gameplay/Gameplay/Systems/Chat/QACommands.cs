// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Chat.QACommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.Systems.Chat;

public class QACommands
{
  [ChatSubCommand("QA", "Receive a mail with buttons, pressing any of the buttons gets you an okbox with the given args.", ChatAuthorizationLevel.DevTier)]
  public static void GetMailWithButtons(
    User user,
    int count = 1,
    int testModeVal = 0,
    int messageType = 0,
    int state = 0,
    string color = "");

  private enum MailButtonTestMode
  {
    Normal,
    BadLinkId,
    BadRPCName,
    BadArgs,
    DiffUser,
  }
}
