// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Emotes
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared;

public static class Emotes
{
  public const 
  #nullable disable
  string SleepEmote = "body_sleep";
  public static EmoteConfig CourtConfig;
  public static EmoteConfig DanceConfig;
  public static EmoteConfig FaceConfig;
  public static EmoteConfig UpperBodyConfig;
  public static EmoteConfig FullBodyOnlyConfig;
  public static EmoteConfig FullBodySitting;
  public static EmoteConfig GroundedConfig;
  public static List<Emote> All;

  /// <summary> Checks if emote id equals case for stopping emotes </summary>
  public static bool IsNone(string emoteID);

  /// <summary> Gets emote by id </summary>
  public static bool TryGet(string emoteID, out Emote emote);

  /// <summary> Gets emote by id </summary>
  public static Emote Get(string emoteID);

  /// <summary> Gets all emotes for specified category id</summary>
  public static IEnumerable<Emote> FromCategory(string categoryID, IEnumerable<Emote> source = null);

  /// <summary> Gets all used, distinct emote categories </summary>
  public static EmoteCategory[] GetAllUsedCategories(IEnumerable<Emote> source = null);
}
