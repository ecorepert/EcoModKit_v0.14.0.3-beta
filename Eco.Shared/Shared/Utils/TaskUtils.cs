// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TaskUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Static utility methods for working with .NET tasks.</summary>
public static class TaskUtils
{
  /// <summary>Excepts if the task is unfinished, and returns the result otherwise.</summary>
  public static T EnsureComplete<T>(this Task<T> task);

  public static void WaitWithoutCapturedContext(Func<Task> task);

  /// <summary>Ensures that if <paramref name="task" /> fails with exception then the exception will be recorded in log.</summary>
  /// <remarks>Usually you should avoid to run detached tasks (like `async void Something()`), but if for some reason that necessary then instead make two methods: `void Something() =&gt; SomethingAsync().WithExceptionLog("category");` and convert former to proper async method with Task result `async Task SomethingAsync()`.
  /// Implemented that way you will be able to use both async version where it supported and at least have exception logging for detached async methods (which will silently fail otherwise).</remarks>
  public static Task WithExceptionLog(this Task task);

  /// <summary> Runs <paramref name="action" /> in background with <see cref="M:System.Threading.Tasks.Task.Run(System.Action)" />, but wraps call in try-catch for exception logging. </summary>
  public static Task RunWithExceptionLog(Action action);

  /// <inheritdoc cref="M:Eco.Shared.Utils.TaskUtils.WithTimeoutAsync``1(System.Threading.Tasks.Task{``0},System.Int32)" />
  public static Task WithTimeoutAsync(this Task task, int timeoutMs);

  /// <inheritdoc cref="M:Eco.Shared.Utils.TaskUtils.TryWithTimeoutAsync``1(System.Threading.Tasks.Task{``0},System.Int32)" />
  public static Task<bool> TryWithTimeoutAsync(this Task task, int timeoutMs);

  /// <summary>Awaits a task for no longer than specified time. If task is not completed by then it throws <see cref="T:System.TimeoutException" />.</summary>
  /// <param name="timeoutMs">Timeout in milliseconds. Pass <see cref="F:System.Threading.Timeout.Infinite" /> to never time out. Pass 0 to time out immediately.</param>
  /// <returns>Task that can be awaited. If the task times out it will throw <see cref="T:System.TimeoutException" />.</returns>
  /// <remarks>
  /// When a timeout occures an exception is thrown, but the original task is not canceled and runs to completion.
  /// If the original task throws an exception after the timeout, it won't be caught or rethrown by this method.
  /// If the original task throws an exception before the timeout, it will be rethrown by this method.
  /// </remarks>
  public static Task<T> WithTimeoutAsync<T>(this Task<T> task, int timeoutMs);

  /// <summary>Awaits a task for no longer than specified time.</summary>
  /// <param name="timeoutMs">Timeout in milliseconds. Pass <see cref="F:System.Threading.Timeout.Infinite" /> to never time out. Pass 0 to time out immediately.</param>
  /// <returns>
  /// Task that can be awaited. When original task completes before timeout result of the returned task is a tuple containing true and result of the original task.
  /// Otherwise the result of returned task is a tuple with false and default value for the result type of the original task.
  /// </returns>
  /// <remarks>
  /// When a timeout occures the original task is not canceled and runs to completion.
  /// If the original task throws an exception after the timeout, it won't be caught or rethrown by this method.
  /// If the original task throws an exception before the timeout, it will be rethrown by this method.
  /// </remarks>
  public static Task<(bool Success, T? Result)> TryWithTimeoutAsync<T>(
    this Task<T> task,
    int timeoutMs);
}
