// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.ParamExplanation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Reflection;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>Lists params relevant to the player, optionally showing currently assigned values of passed in instances, along with descriptions of each.</summary>
public static class ParamExplanation
{
  public static 
  #nullable disable
  string SimpleDescribeProperties(object instance);

  public static LocString DescribeType(Type type, params object[] instances);

  public static LocString DescribeType(
    Type type,
    bool showHeaders,
    Func<MemberInfo, bool> filter,
    params object[] instances);

  public static void DescribeTypeAttributes(this Type type, LocStringBuilder sb);

  public static LocString[,] Table2d(Type type, object[] instances);

  public static LocString[,] Table2dStrippedTags(Type type, object[] instances);

  public static string[,] Table2dStrippedTagsAsString(Type type, object[] instances);

  public static IEnumerable<IEnumerable<LocString>> Table(
    Type type,
    bool showHeaders,
    Func<MemberInfo, bool> filter,
    object[] instances);

  /// <summary> Forms the list containing the display text of a row that describes a type's property. <para> Currently holds 'Icon + Name' on first index, and 'Description' (if any) on second index. </para> </summary>
  public static List<LocString> GetDescriptionRowForProperty(
    Type baseType,
    PropertyInfo prop,
    object[] instances = null);
}
