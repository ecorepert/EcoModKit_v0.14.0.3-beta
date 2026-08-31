// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Async.AsyncFactory
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.Utils.Async;

/// <summary>
/// AsyncFactory creates Task from different async objects.
/// </summary>
public static class AsyncFactory
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ValueTask<bool> FromWaitHandle(WaitHandle handle);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ValueTask<bool> FromWaitHandle(WaitHandle handle, int millisecondsTimeoutInterval);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ValueTask<bool> FromWaitHandle(
    WaitHandle handle,
    int millisecondsTimeoutInterval,
    CancellationToken cancellationToken);

  /// <summary>
  /// Creates Task from <see cref="T:System.Threading.WaitHandle" />.
  /// Used code sample from https://stackoverflow.com/questions/24119429/rework-eventwaithandle-to-asynchronously-await-signal.
  /// </summary>
  /// <returns>Returns <c>true</c> if event was signaled and <c>false</c> otherwise.</returns>
  public static ValueTask<bool> FromWaitHandle(
    WaitHandle handle,
    int millisecondsTimeoutInterval,
    CancellationToken cancellationToken,
    TaskScheduler taskScheduler);
}
