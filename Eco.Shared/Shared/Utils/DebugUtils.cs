// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.DebugUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils;

public static class DebugUtils
{
  public static bool AssertShouldThrow;
  public static bool DebugBreakEnabled;

  public static bool IsShuttingDown { get; }

  public static void Noop();

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void Assert([DoesNotReturnIf(false)] bool val, string message);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void Assert([DoesNotReturnIf(false)] bool val, AssertionFlags flags, string message);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void Assert(
    [DoesNotReturnIf(false)] bool val,
    AssertionFlags flags,
    [InterpolatedStringHandlerArgument("val")] ref AssertInterpolatedStringHandler handler);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void Assert([DoesNotReturnIf(false)] bool val, [InterpolatedStringHandlerArgument("val")] ref AssertInterpolatedStringHandler handler);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void AssertEquals<T>(T expected, T actual, string message = null);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void AssertNotNull(object value, string message = null);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  [DoesNotReturn]
  public static void Fail(string message);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  [DoesNotReturn]
  public static void Fail(AssertionFlags flags, string message);

  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void OnShuttingDown();

  public static void PrettyPrint(this Exception e);

  public static string ToStringPretty(this Exception e);

  public static string Details(Exception e);
}
