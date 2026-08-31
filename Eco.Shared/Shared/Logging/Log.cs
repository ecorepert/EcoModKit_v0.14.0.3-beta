// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Logging.Log
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Shared.Logging;

public static class Log
{
  public static ILogWriter Writer { set; }

  /// <summary>Sets dummy writer that does nothing, but prevents <see cref="M:Eco.Shared.Logging.Log.AssertInitialized" /> from failing.</summary>
  /// <remarks>This method should only be used in unit tests that test systems which use logging.</remarks>
  public static void SetDummyWriter();

  public static void Write(LocString message);

  public static void WriteLine(LocString message);

  public static void WriteLineLoc(FormattableString s);

  public static void WriteLineNL(FormattableString s);

  public static void WriteWarning(LocString message, int maxRepeats = 0);

  public static void WriteWarningLine(LocString message, int maxRepeats = 0);

  public static void WriteWarningLineLoc(FormattableString message, int maxRepeats = 0);

  public static void WriteWarningLineLocStr(string message, int maxRepeats = 0);

  public static void WriteError(LocString message, bool stripTags = false);

  public static void WriteErrorLoc(FormattableString message, bool stripTags = false);

  public static void WriteErrorLine(LocString message, bool stripTags = false);

  public static void WriteErrorLineLoc(FormattableString message, bool stripTags = false);

  public static void WriteErrorLineLocStr(string message, bool stripTags = false);

  public static void WriteErrorLineNL(FormattableString message, bool stripTags = false);

  public static void WriteErrorLineNLS(string message, bool stripTags = false);

  public static void WriteError(LocString message, Exception ex, bool stripTags = false);

  public static void WriteException(Exception ex, bool stripTags = false);

  public static bool AddDisplayedError(string message, int maxRepeats = 0);

  /// <summary>When shutting down report amount of times called per issue.</summary>
  public static void WriteErrorsSummary();

  public static void Debug(string message);
}
