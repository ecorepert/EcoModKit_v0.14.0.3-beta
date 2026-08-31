// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.CategoryExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

public static class CategoryExtensions
{
  public static string CategoryDescription(this CategoryContainment cat, IEnumerable<string> list);

  /// <summary>Tests if elements from a set are contained in another set using passed function for testing.</summary>
  /// <param name="containerName">Name of the set which has to contain or not contain elements of the passed set. Used to create message describing the result.</param>
  /// <param name="set">Set that will be tested for specified requirements.</param>
  /// <param name="evalulate">Function that returns true if passed element of the passed set is contained in the other set. Also returns name.</param>
  /// <param name="hasString">String used to describe situation when elements are part of a set (like 'are part of').</param>
  /// <param name="notHasString">String used to describe situation when elements are not part of a set (like 'are not part of').</param>
  /// <param name="elementTypeSingular">Word that describes elements of the set in singular form. Used to create text for link that opens a foldout list if list of elements is too long (like '1 element').</param>
  /// <param name="elementTypePlural">Word that describes elements of the set in plural form. Used to create text for link that opens a foldout list if list of elements is too long (like '9 elements').</param>
  /// <returns>Eval with value indicating whether the test was passed and message explaining why test was passed or not in format 'containerName hasString/notHasString list-of-elements'.</returns>
  public static Eval<bool> Test<T>(
    this CategoryContainment requirement,
    IEnumerable<T> set,
    Func<T, Eval<bool>> evalulate,
    LocString containerName,
    LocString hasString,
    LocString notHasString,
    LocString elementTypeSingular,
    LocString elementTypePlural);

  /// <summary>Tests if passed cases evaluate to boolean value matching defined requirement using passed function for evaluation.</summary>
  /// <param name="containerName">Name of the object for which cases are tested. Used to create message describing the result.</param>
  /// <param name="cases">Cases that will be tested for specified requirements.</param>
  /// <param name="evaluate">Function that returns boolean Eval value to which passed case is evaluated, uses Message as name.</param>
  /// <param name="trueString">String used to describe situation when cases are evaluated to true (like 'are true').</param>
  /// <param name="falseString">String used to describe situation when cases are evaluated to false (like 'are false').</param>
  /// <param name="elementTypeSingular">Word that describes all cases in singular form. Used to create text for link that opens a foldout list if list of cases is too long (like '1 case').</param>
  /// <param name="elementTypePlural">Word that describes all cases in plural form. Used to create text for link that opens a foldout list if list of cases is too long (like '9 cases').</param>
  /// <returns>Eval with value indicating whether the test was passed and message explaining why test was passed or not in format 'containerName trueString/falseString list-of-cases'.</returns>
  public static Eval<bool> Test<T>(
    this RequiredTrue requirement,
    IEnumerable<T> cases,
    Func<T, Eval<bool>> evaluate,
    LocString containerName,
    LocString trueString,
    LocString falseString,
    LocString elementTypeSingular,
    LocString elementTypePlural);

  public static bool RequiresAll(this CategoryContainment requirement);

  public static bool InclusionTest(this CategoryContainment requirement);
}
