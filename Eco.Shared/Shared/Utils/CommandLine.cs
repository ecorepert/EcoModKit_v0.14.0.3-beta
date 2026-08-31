// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.CommandLine
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>
/// Class for getting arguments from command line. Arguments are not case sensitive.
/// 
/// Excpected syntax of parameters:
/// * -arg
/// * -arg="value"
/// * -arg.subarg="value"
/// </summary>
public static class CommandLine
{
  /// <summary>Sets command line from unparsed <paramref name="commandLine" /> string.</summary>
  public static void SetCmdLine(string commandLine);

  public static void SetCmdLine(string[] args);

  /// <summary>Gets whether an argument is set or not. Not case sensitive.</summary>
  public static bool GetValuelessArg(string argName);

  /// <summary>Gets the value for a given argument is set, null otherwise. Not case sensitive.</summary>
  public static string? GetValueArg(string argName);

  /// <summary>Basic deserialization of data passed by command line. Can be partial defined (only particular properties).</summary>
  public static bool FeedFromCommandLine(this object obj);

  /// <summary>Basic serialization of properties of object, so they can be parsed by FeedFromCommandLine function.</summary>
  public static string ToCommandLineArgs(this object obj, Func<object?, bool>? filter = null);
}
