// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.TagUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

public static class TagUtils
{
  public static 
  #nullable disable
  IEnumerable<Tag> Tags(this Type type);

  public static IEnumerable<Tag> Tags(this Item item);

  public static bool HasTag(this Type type, Tag tag);

  public static bool HasAnyTag(this Type type, IEnumerable<Tag> tags);

  public static bool HasAllTags(this Type type, IEnumerable<Tag> tags);

  public static bool HasNoneTags(this Type type, IEnumerable<Tag> tags);

  public static bool HasAnyTag(this Type type, params Tag[] tags);

  public static bool HasAllTags(this Type type, params Tag[] tags);

  public static bool HasNoneTags(this Type type, params Tag[] tags);

  public static IEnumerable<Type> TaggedTypes(this Tag tag);

  public static IEnumerable<Item> TaggedItems(this Tag tag);

  public static bool BlockHasAnyTag(Vector3i worldPos, IEnumerable<Tag> tags);

  public static bool BlockHasAnyTag(Vector3i worldPos, params Tag[] tags);

  public static bool BlockHasAllTags(Vector3i worldPos, IEnumerable<Tag> tags);

  public static bool BlockHasAllTags(Vector3i worldPos, params Tag[] tags);

  public static bool BlockHasNoneTags(Vector3i worldPos, IEnumerable<Tag> tags);

  public static bool BlockHasNoneTags(Vector3i worldPos, params Tag[] tags);

  /// <summary>Checks if given type meets all tag requirements. Pass null to requirement to ignore it.</summary>
  public static bool MeetsTagRequirements(
    this Type type,
    IEnumerable<Tag> hasAny,
    IEnumerable<Tag> hasAll,
    IEnumerable<Tag> hasNone);

  public static bool BlockMeetsTagRequirements(
    Vector3i worldPos,
    IEnumerable<Tag> hasAny,
    IEnumerable<Tag> hasAll,
    IEnumerable<Tag> hasNone);

  /// <summary>Given a list of specifications (a number of tags or items), modify it and return how many are satisfied by the passed in item and quantity.</summary>
  public static int TrySatisfySpecs(this IEnumerable<IStack> specStacks, Item item, int quantity);

  /// <summary> Returns string collection of object's tags. </summary>
  public static IEnumerable<string> TagNames(this object obj, bool includeHidden = true);

  public static IEnumerable<LocString> TagDisplayNames(this object obj, bool includeHidden = true);

  /// <summary> Collects tags of entries and tries to find the best match that is present in each of them. </summary>
  public static Tag GetBestTag(this IEnumerable<object> entries);
}
