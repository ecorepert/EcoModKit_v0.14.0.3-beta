// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TimedTaskProgressLogging
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary> Utility functions to log TimedTask start and progress to the console, and parse and format the same messages for when running the server through the client</summary>
public static class TimedTaskProgressLogging
{
  public const int Padding = 50;

  /// <summary> Log task start to console with padding </summary>
  public static void LogTask(string name);

  /// <summary> Log task progress to console with cursor offset. Resets cursor position after writting. </summary>
  public static void LogProgress(string message, int cursorX, int cursorY);

  /// <summary> Log task and progress to console. Used when same line reporting is not available </summary>
  public static void LogTaskAndProgress(string name, string message);

  /// <summary> Parse the name and progress of a task console message and format it for client UI display. Used by the client when running the server through the client. </summary>
  public static Tuple<string, string> ParseAndFormatLogParts(string log);
}
