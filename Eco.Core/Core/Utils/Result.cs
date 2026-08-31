// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Result
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Utils;

[DebuggerDisplay("{ToStringStripped}")]
public class Result
{
  public ResultType Value;
  public string Debug;

  public static Result Succeeded { get; }

  public static Result FailedNoMessage { get; }

  public bool Success { get; set; }

  public bool Failed { get; }

  public bool IsNotifiedFor(object target);

  /// <summary>Atomically marks <paramref name="target" /> as notified. Returns <c>true</c> if it was newly added (caller should fire the notification),
  /// <c>false</c> if it was already present (caller should skip).</summary>
  public bool TryMarkNotifiedFor(object target);

  public LocString Message { get; set; }

  public Eco.Shared.Services.NotificationStyle? NotificationStyle { get; set; }

  public Eco.Shared.Services.NotificationCategory? NotificationCategory { get; set; }

  public string ToStringStripped { get; }

  public Result();

  public Result(ResultType type);

  protected Result(Result result);

  public Result(LocString message, bool success = false);

  public Result(string message, bool success = false);

  public override string ToString();

  public static Result Localize(FormattableString s, bool success = false);

  public static Result LocalizeStr(string s, bool success = false);

  public static Result Fail(LocString s);

  public static Result FailNT(FormattableString s);

  public static Result FailNTStr(string s);

  public static Result FailLocStr(string s);

  public static Result FailLoc(FormattableString s);

  public static Result SucceedLoc(FormattableString s);

  public static Result Succeed(LocString s);

  public static Result SucceedNT(FormattableString s);

  public static Result SucceedNTStr(string s);

  public static Result SetSucceed(bool success, LocString s = default (LocString));

  public static Result SetIfFailedLoc(FormattableString failMessage, bool success);

  /// <summary>
  /// Check if result failed and saves fail message into output parameter.
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool IsFailed(out LocString message);

  /// <summary>
  /// Taps this to another <paramref name="result" /> if <paramref name="result" /> has no value and returns this.
  /// Useful in workflow where you want to check multiple results sequentially and remember first result.
  /// </summary>
  public Result TapToIfNotSet(ref Result result);

  public static implicit operator bool(Result result);

  public static Result RunAll(params Func<Result>[] p);

  public static Result Merge(IEnumerable<Result> others);

  public virtual Result Merge(Result other);

  public void AppendDebugLoc(FormattableString debugText);

  public void AppendDebug(string debugText);

  public Result MergeFail(string other);

  public Result MergeFailLoc(FormattableString other);

  public Result Test(Func<Result> p);

  public void AppendLine(FormattableString other);

  public void AppendLine(LocString other);

  public static Result AnnotateIfFailed(bool result, string parameterName, string objectName);

  public Result PrependNT(string other, string spacer = " ");

  public Result Prepend(FormattableString other, string spacer = " ");

  public Result Prepend(LocString other, string spacer = " ");

  public Result FixCaps();

  public static Result None(string debugText);
}
