// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValueUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

public static class GameValueUtils
{
  /// <summary>
  /// Does the test for a GameValue, notifies in a failure, and returns true or false for "should we continue"
  /// </summary>
  /// <param name="reqs"></param>
  /// <param name="failureDesc"></param>
  /// <param name="context"></param>
  /// <param name="notify"></param>
  /// <returns></returns>
  public static bool TryLoc(
    this GameValue<bool> reqs,
    FormattableString failureDesc,
    IContextObject context,
    User notify);

  public static bool NonZero(this GameValue<float> num);

  public static bool NullOrZero(this GameValue<float> num);

  public static bool IsNegative(this GameValue<float> num);

  public static bool IsZero(this GameValue<float> num);

  public static bool IsSimpleBool(this GameValue<bool> num);

  /// <summary>If the game value is a simple wrapped value that's always true then we return true.</summary>
  public static bool IsSimpleTrue(this GameValue<bool> num);

  /// <summary>If the game value is a simple wrapped value that's always false then we return true.</summary>
  public static bool IsSimpleFalse(this GameValue<bool> num);

  public static bool IsConstant(this GameValue<float> num, float val);

  public static bool TryGetConstant(this GameValue<float> num, out float val);

  /// <summary> Make a generic Fail Eval param with a nice message. Assumes the paramname is already tagged as localized elsewhere (as members are when marked with [Eco]). </summary>
  public static Eval<TEvalReturn> FailNullSafe<TEvalReturn, TEvalParam>(
    this GameValue gameValue,
    Eval<TEvalParam> eval,
    string paramName);

  public static Eval<TEvalReturn> Missing<TEvalReturn>(this GameValue gameValue, string paramName);

  public static string DescribeNullSafe(this GameValue val);

  public static string DescribeNullSafe(this IDescribable val);

  public static LocString UILinkNullSafe(this ILinkable val);
}
