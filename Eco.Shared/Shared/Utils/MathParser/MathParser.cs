// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MathParser.MathParser
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils.MathParser;

/// <summary> Parses and evaluates math expressions. </summary>
public static class MathParser
{
  public static string AllowedOperators { get; }

  public static string AllowedOperatorsRegex { get; }

  public static LocString NoOperandError { get; }

  /// <summary> Replaces text representations of the variable with the provided value.
  /// Note that it looks for exact matches and if 'Example' is passed, it won't touch 'Also Example', though the second one contains provided representation. </summary>
  /// <param name="expression"> A string that contains text representations of the variable. </param>
  /// <param name="variableName"> Text representation that will be replaced. </param>
  /// <param name="value"> This will replace text representation of the variable in the provided expression. </param>
  /// <returns> Modified expression, where text representations of the varible are replaced with the provided value. </returns>
  public static string ReplaceVariable(string expression, string variableName, float value);

  public static string ReplaceVariable(string expression, string variableName, string value);

  /// <summary>  Extracts variables from the provided string (ignores constant values like 3.14 or 72). </summary>
  public static IEnumerable<string> GetVariables(string input);

  /// <summary>  Compares two provided collections and returns missmatches and declared duplicates. </summary>
  public static (string[] Undeclared, string[] Unused, string[] Duplicates) CompareNames(
    IEnumerable<string> declared,
    IEnumerable<string> needed);

  /// <summary> Replaces text representations of variables with their values. Each value will show its name and description in a foldout when hovered. </summary>
  public static string DescribeValues(
    string expression,
    Dictionary<string, (float Value, LocString Description)> nameToDefinition);

  /// <summary> Converts provided expression into a binary tree and returns its root node (null if failed to parse). </summary>
  public static (BinaryNode Root, LocString Error) BuildTree(string expression);

  public static OperationType? ParseOperator(string input);

  /// <summary> Replaces newline characters with spaces and trims the result. </summary>
  public static string OnelineAndTrim(this string input);
}
