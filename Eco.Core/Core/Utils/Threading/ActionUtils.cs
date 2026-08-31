// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.ActionUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.Utils.Threading;

public static class ActionUtils
{
  /// <summary> Represents <see cref="T:System.Action" /> as async action with immediate execution (invokes the <paramref name="action" /> and returns <see cref="P:System.Threading.Tasks.Task.CompletedTask" />). </summary>
  public static Func<Task> AsAsyncAction(Action action);

  /// <summary> Represents <see cref="T:System.Action" /> as async cancellable action with immediate execution (invokes the <paramref name="action" /> and returns <see cref="P:System.Threading.Tasks.Task.CompletedTask" />). </summary>
  public static Func<CancellationToken, Task> AsAsyncCancellableAction(Action action);

  public static void SubscribeAndCall(this Action a, Action callback);

  public static void SubscribeAndCall<T1>(this Action<T1> a, Action callback);

  public static void SubscribeAndCall<T1, T2>(this Action<T1, T2> a, Action callback);

  /// <summary>Try to invoke actions passing parameter to each of them. Return true if they all succeed and false if any of them fails with an exception.</summary>
  /// <param name="exceptions">Exceptions thrown by actions. Null if none were thrown.</param>
  public static bool TryInvokeAll<T>(
    this IEnumerable<Action<T>> actions,
    T parameter,
    out List<Exception> exceptions);

  /// <summary>Try to invoke actions by passing them along with parameter to invoke function. Return true if they all succeed and false if any of them fails with an exception.</summary>
  /// <param name="exceptions">Exceptions thrown by actions. Null if none were thrown.</param>
  /// <param name="invoke">Function that will be called to invoke each action.</param>
  public static bool TryInvokeAll<TDelegate, TParam>(
    this IEnumerable<TDelegate> actions,
    TParam parameter,
    Action<TDelegate, TParam> invoke,
    out List<Exception> exceptions)
    where TDelegate : Delegate;

  /// <summary>Try to invoke action. Return true if it succeeds and false if it fails with an exception.</summary>
  /// <param name="exception">Exception thrown by action. Null if no exception is thrown.</param>
  public static bool TryInvoke<T>(this Action<T> action, T parameter, out Exception exception);

  /// <summary>Try to invoke action. Return true if it succeeds and false if it fails with an exception.</summary>
  /// <param name="exception">Exception thrown by action. Null if no exception is thrown.</param>
  public static bool TryInvoke<T1, T2>(
    this Action<T1, T2> action,
    T1 parameter1,
    T2 parameter2,
    out Exception exception);
}
