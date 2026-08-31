// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.LazyResult
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Utils;

/// <summary>Simple struct for tracking a result that holds off generating a string till requested</summary>
public ref struct LazyResult
{
  private static readonly Result SuceededResult;
  private static readonly Result FailedNoMessageResult;
  public readonly ResultType Value;
  private readonly object? context;
  private object resultOrGenerator;

  public static LazyResult Succeeded { get; }

  public static LazyResult FailedNoMessage { get; }

  /// <summary>Check if <see cref="T:Eco.Core.Utils.Result" /> is success.</summary>
  public readonly bool Success { get; }

  public LocString Message { get; }

  public Eco.Shared.Services.NotificationStyle? NotificationStyle { get; }

  /// <summary>Constructs <see cref="T:Eco.Core.Utils.LazyResult" /> for stateless <see cref="T:Eco.Core.Utils.Result" />. Best to be used with reusable cached result defined as static lass member. In that case it has zero-allocations even when resolved with <see cref="M:Eco.Core.Utils.LazyResult.Resolve" />.</summary>
  public LazyResult(Result result);

  /// <summary>Constructs <see cref="T:Eco.Core.Utils.LazyResult" /> for context aware <see cref="T:Eco.Core.Utils.Result" />, usually when you need to build a message with link to some context object like a User, or Account, or Deed, or whatever. Ensure that <paramref name="success" /> is always in sync with generated result <see cref="P:Eco.Core.Utils.Result.Success" />.</summary>
  /// <example><code>new LazyResult(false, user, user =&gt; Result.FailLoc($"Failed for {user.UILink()}"));</code></example>
  public LazyResult(bool success, object? context, Func<object, Result> resultOrGenerator);

  /// <summary>Creates new <see cref="T:Eco.Core.Utils.Result" /> from <see cref="T:Eco.Core.Utils.LazyResult" />. Don't use it unless really necessary, prefer to use other functions on <see cref="T:Eco.Core.Utils.LazyResult" /> to check result state and it's message. You still may need this function if you need to pass the Result to another function and use it to merge another results into it.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Result CreateResult();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static implicit operator bool(LazyResult lazyResult);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static explicit operator LazyResult(Result result);
}
