// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.ProfanityUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Shared.Networking;

#nullable enable
namespace Eco.Gameplay.Utils;

/// <summary>Utility functions for interacting with Eco's profanity check system.</summary>
public static class ProfanityUtils
{
  /// <summary>Replaces text in case it contains profanity and informs the player with a warning</summary>
  /// <param name="text">Text <see cref="T:System.String" /> to profanity check</param>
  /// <param name="replaceText">Text <see cref="T:System.String" /> to replace profanity with.</param>
  /// <param name="target"><see cref="T:Eco.Gameplay.Players.Player" /> this profanity originated from.</param>
  /// <returns>True if profanity was detected</returns>
  public static bool ReplaceIfNotClear(
    ref string text,
    string replaceText,
    INotificationReceiver target);

  /// <summary>Check text in case it contains profanity and informs the player with a warning</summary>
  /// <param name="text">Text <see cref="T:System.String" /> to profanity check</param>
  /// <param name="target"><see cref="T:Eco.Gameplay.Players.Player" /> this profanity originated from.</param>
  /// <returns>True if profanity was detected</returns>
  public static bool CheckAndWarn(string text, INotificationReceiver target);

  /// <summary>Informs a <see cref="T:Eco.Gameplay.Players.Player" /> instance about inappropriate text found in a profanity check.</summary>
  /// <param name="target"><see cref="T:Eco.Gameplay.Players.Player" /> to inform about the detected profanity.</param>
  /// <param name="newText">Original uncensored text <see cref="T:System.String" /> to inform the user about.</param>
  /// <param name="oldText">The new filtered text <see cref="T:System.String" /> the profanity was replaced with.</param>
  public static void Warn(INotificationReceiver? target, string newText, string oldText);

  /// <summary> RPC profanity version of Warn </summary>
  public static void Warn(INetClient client, string newText, string oldText);
}
