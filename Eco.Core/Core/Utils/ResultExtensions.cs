// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ResultExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Services;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

public static class ResultExtensions
{
  public static Result ToResult(this Eval<bool> v);

  public static Eval<bool> Invert(this Eval<bool> source);

  public static Result Annotate(this Result result, string parameterName, string objectName);

  public static TResult RunAll<T, TResult>(this IEnumerable<T> list, Func<T, TResult> test) where TResult : Result, new();

  public static (T Entry, TResult Result) RunAllObj<T, TResult>(
    this IEnumerable<T> list,
    Func<T, TResult> test)
    where TResult : Result, new();

  public static Result Merge(this IEnumerable<Result> list);

  public static Result MergeCounted(this IEnumerable<Result> list);

  public static bool IsSuccessWithChanges(this ValResult<int> res);

  public static Result WithStyle(this Result res, NotificationStyle style);

  public static Result WithStyleAndCategory(
    this Result res,
    NotificationStyle style,
    NotificationCategory category);

  public static ValResult<T> WithVal<T>(this Result result, T val);

  public static ValResult<T> WithMessageAndVal<T>(this Result result, T val);

  public static ValResult<T> DefaultVal<T>(this Result result);

  public static Result FirstSuccess<T>(this IEnumerable<T> list, Func<T, Result> resultGetter);
}
