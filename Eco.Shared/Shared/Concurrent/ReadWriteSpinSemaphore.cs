// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Concurrent.ReadWriteSpinSemaphore
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Concurrent;

/// <summary>
/// Very lightweight semaphore-like synchronization object based on <see cref="T:System.Threading.SpinWait" />.
/// It optimized for very-short write operations and concurrent read operations (short enough). It may spent lot of CPU cycles if you don't follow this rule.
/// To achieve this internal state maintained which may be (-1 - for write operation in progress, 0 - for no operations, positive - for read operations). When positive it is equal to number of active read operations.
/// <see cref="M:Eco.Shared.Concurrent.ReadWriteSpinSemaphore.WaitWrite" /> should be used for write operations and it will await when <see cref="F:Eco.Shared.Concurrent.ReadWriteSpinSemaphore.state" /> is 0 to switch state to -1. When write operation finished <see cref="M:Eco.Shared.Concurrent.ReadWriteSpinSemaphore.ReleaseWrite" /> should be used to allow other write and read operations.
/// <see cref="M:Eco.Shared.Concurrent.ReadWriteSpinSemaphore.WaitRead" /> should be used for read operations and it will await until <see cref="F:Eco.Shared.Concurrent.ReadWriteSpinSemaphore.state" /> is greater or equal to 0 (no write operations in progress) and then increases state value. When read operation finished <see cref="M:Eco.Shared.Concurrent.ReadWriteSpinSemaphore.ReleaseRead" /> should be used to allow write operations.
/// WARNING! Because this is a struct you should never ever copy it and always as an class field only. Read more in <see cref="T:System.Threading.SpinLock" /> documentation (https://docs.microsoft.com/en-us/dotnet/api/System.Threading.SpinLock?view=net-7.0).
/// </summary>
public struct ReadWriteSpinSemaphore
{
  private const int SleepOneFrequency = 40;
  private int state;

  /// <summary>Waits for Read operation availability and modifies state to prevent concurrent write operations.</summary>
  public void WaitRead();

  /// <summary>Releases active Read operation. All Read operations should be released before any Write operation may start.</summary>
  public void ReleaseRead();

  /// <summary>Waits for Write operation availability and modifies state to prevent other write and read operations.</summary>
  public void WaitWrite();

  /// <summary>Releases active Write operation. No other operation may happen until Write released.</summary>
  public void ReleaseWrite();
}
