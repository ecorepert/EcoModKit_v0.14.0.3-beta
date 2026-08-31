// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ImmutableHelper
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Utils;

public static class ImmutableHelper
{
  public static void ApplyImmutable<T>(ref T original, Func<T, T> apply) where T : class;

  public static void ApplyImmutable<T, TArg>(ref T original, TArg arg, Func<T, TArg, T> apply) where T : class;

  public static void ApplyImmutable<T, TArg1, TArg2>(
    ref T original,
    TArg1 arg1,
    TArg2 arg2,
    Func<T, TArg1, TArg2, T> apply)
    where T : class;

  public static void ApplyImmutable<T, TArg1, TArg2, TArg3>(
    ref T original,
    TArg1 arg1,
    TArg2 arg2,
    TArg3 arg3,
    Func<T, TArg1, TArg2, TArg3, T> apply)
    where T : class;

  /// <summary> Applies a passed function to an immutable container, and returns the given value that comes back through the tuple.</summary>
  /// <typeparam name="T">The immutable container</typeparam>
  /// <typeparam name="TResult">The result of the operation. Can be a bool for success, or some other type (like a list for extracting values)</typeparam>
  /// <param name="original">The immutable container this is being run upon</param>
  /// <param name="apply">A function run on every entry of the container, which will return a tuple: (the new updated container, the value to pass back to the caller)</param>
  /// <returns>Returns the result of the application of the func over the container.</returns>
  public static TResult ApplyImmutableReturn<T, TResult>(
    ref T original,
    Func<T, (T Object, TResult Result)> apply)
    where T : class;

  public static TResult ApplyImmutableReturn<T, TArg, TResult>(
    ref T original,
    TArg arg,
    Func<T, TArg, (T Object, TResult Result)> apply)
    where T : class;

  public static TResult ApplyImmutableReturn<T, TArg1, TArg2, TResult>(
    ref T original,
    TArg1 arg1,
    TArg2 arg2,
    Func<T, TArg1, TArg2, (T Object, TResult Result)> apply)
    where T : class;
}
