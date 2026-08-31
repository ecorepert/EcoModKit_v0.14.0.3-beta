// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.LockUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Threading;

#nullable disable
namespace Eco.Shared.Utils;

public static class LockUtils
{
  public static LockUtils.ExitReadLockOnDispose EnterDisposableReadLock(this ReaderWriterLockSlim l);

  public static LockUtils.ExitWriteLockOnDispose EnterDisposableWriteLock(
    this ReaderWriterLockSlim l);

  public static LockUtils.ExitReadLockOnDispose TryEnterDisposableReadLock(
    this ReaderWriterLockSlim l,
    int timeout);

  public static LockUtils.ExitWriteLockOnDispose TryEnterDisposableWriteLock(
    this ReaderWriterLockSlim l,
    int timeout);

  public static LockUtils.ExitUpgradeableReadLockOnDispose EnterDisposableUpgradeableReadLock(
    this ReaderWriterLockSlim l);

  public static bool TryLock(object lockObject, Action ifLockAcquired, int millisecondsTimeout = 0);

  /// <summary>
  /// Disposable structure which guarantees that <see cref="F:Eco.Shared.Utils.LockUtils.ExitReadLockOnDispose.rwLock" /> will exit read lock when <see cref="M:Eco.Shared.Utils.LockUtils.ExitReadLockOnDispose.Dispose" /> called. Handy when you wanna to use it with `using` pattern.
  /// We are not using something like <see cref="M:Eco.Shared.Utils.DisposableUtils.FromAction(System.Action)" /> because it creates new delegate every time what is bad both for performance and memory allocations.
  /// </summary>
  public readonly struct ExitReadLockOnDispose : IDisposable
  {
    private readonly ReaderWriterLockSlim rwLock;

    public ExitReadLockOnDispose(ReaderWriterLockSlim rwLock);

    public void Dispose();
  }

  /// <summary>
  /// Disposable structure which guarantees that <see cref="F:Eco.Shared.Utils.LockUtils.ExitWriteLockOnDispose.rwLock" /> will exit write lock when <see cref="M:Eco.Shared.Utils.LockUtils.ExitWriteLockOnDispose.Dispose" /> called. Handy when you wanna to use it with `using` pattern.
  /// We are not using something like <see cref="M:Eco.Shared.Utils.DisposableUtils.FromAction(System.Action)" /> because it creates new delegate every time what is bad both for performance and memory allocations.
  /// </summary>
  public readonly struct ExitWriteLockOnDispose : IDisposable
  {
    private readonly ReaderWriterLockSlim rwLock;

    public ExitWriteLockOnDispose(ReaderWriterLockSlim rwLock);

    public void Dispose();
  }

  /// <summary>
  /// Disposable structure which guarantees that <see cref="F:Eco.Shared.Utils.LockUtils.ExitUpgradeableReadLockOnDispose.rwLock" /> will exit upgradeable read lock when <see cref="M:Eco.Shared.Utils.LockUtils.ExitUpgradeableReadLockOnDispose.Dispose" /> called. Handy when you wanna to use it with `using` pattern.
  /// We are not using something like <see cref="M:Eco.Shared.Utils.DisposableUtils.FromAction(System.Action)" /> because it creates new delegate every time what is bad both for performance and memory allocations.
  /// </summary>
  public readonly struct ExitUpgradeableReadLockOnDispose : IDisposable
  {
    private readonly ReaderWriterLockSlim rwLock;

    public ExitUpgradeableReadLockOnDispose(ReaderWriterLockSlim rwLock);

    public void Dispose();
  }
}
