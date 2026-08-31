// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ActionUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Shared.Utils;

public static class ActionUtils
{
  public static 
  #nullable disable
  Action SubscribeUnique(this Action a, Action callback);

  /// <summary>Calls an async func, and catches any exception it triggers and packs it into a tuple with the error as the second param if it fails.</summary>
  public static Task<(T Result, string Error)> TryAndCatchError<T>(this Task<T> action);

  /// <summary>Get the underlying problem out of the exception, if its an exception retruned from Strange Cloud.</summary>
  public static string DecodeError(this Exception ex);

  /// <summary>Calls an async func, and catches any exception it triggers and logs it if theres an error.</summary>
  public static Task TryAndLogError(this Task action);

  /// <summary>Calls an async func, and catches any exception it triggers and logs it if theres an error.</summary>
  /// <returns>Default value for <typeparamref name="T" /> if exception is thrown, otherwise value returned by the original function.</returns>
  public static Task<T> TryAndLogError<T>(this Task<T> action);

  /// <summary>Calls an async func, and catches any exception it triggers and packs it into a tuple with the error as the second param if it fails.</summary>
  public static Task<string> TryAndCatchError(this Task action);

  /// <summary>Calls an async func, and catches any exception it triggers and packs it into a tuple with the error as the second param if it fails.</summary>
  public static Task<(T Result, string Error)> TryAndCatchError<T>(Func<Task<T>> action);
}
