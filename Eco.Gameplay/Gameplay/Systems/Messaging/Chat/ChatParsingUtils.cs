// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.ChatParsingUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

public static class ChatParsingUtils
{
  /// <summary>Given a raw chat message, strips it from size tags and control characters.</summary>
  public static string SanitizeChatInput(string rawText);

  /// <summary>Given a chat message, attempt to extract receiver and actual message part.</summary>
  /// <param name="tag">Message should be user or channel, it can be extracted from text or given directly.</param>
  public static ValResult<IChatReceiver> ResolveReceiver(
    string text,
    out string message,
    string tag = null);
}
