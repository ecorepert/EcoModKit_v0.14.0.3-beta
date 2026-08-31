// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.IUserMarkUpService
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable enable
namespace Eco.Gameplay.Players;

/// <summary>
/// <see cref="T:Eco.Gameplay.Players.IUserMarkUpService" /> is an interface exposed as <c>ServiceHolder{IUserMarkUpService}.Obj</c> for <see cref="T:Eco.Gameplay.Players.User" /> for marking up name, chat tag and name with reputation.
/// It exposed to service to make it extendable by Mods (i.e. for custom titles, prefixes etc).
/// </summary>
public interface IUserMarkUpService
{
  /// <summary>Marks up <paramref name="user" /> name.</summary>
  LocString MarkUpName(User user);

  /// <summary>Marks up chat tag for <paramref name="user" />. This marked up text used in chat for displaying message sender/recipient</summary>
  LocString MarkUpChatTag(User user);

  /// <summary>Plain text name for user's overhead tag (synced to clients).</summary>
  string OverheadName(User user);

  /// <summary>Marked up name combined with marked up reputation.</summary>
  LocString MarkUpReputationAndName(User user);
}
