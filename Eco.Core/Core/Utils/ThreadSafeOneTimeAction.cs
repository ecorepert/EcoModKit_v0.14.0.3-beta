// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeOneTimeAction
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Core.Utils;

/// <summary> Thread-safe utility for executing an action exactly once across multiple threads. Uses lock-free atomic operations. </summary>
[ThreadSafe]
public sealed class ThreadSafeOneTimeAction
{
  public bool WasExecuted { get; }

  /// <summary> Attempts to execute the action. If this is the first call across all threads, executes the action. Subsequent calls do nothing. </summary>
  public void TryExecute(Action action);

  /// <summary> Attempts to execute the action with a parameter. If this is the first call across all threads, executes the action. Subsequent calls do nothing. </summary>
  public void TryExecute<T>(Action<T> action, T parameter);

  /// <summary> Resets the execution state, allowing the action to be executed again. </summary>
  public void Reset();

  /// <summary> Attempts to reset if the action was previously executed, and optionally executes a reset action. </summary>
  public bool TryReset(Action onResetAction = null);
}
