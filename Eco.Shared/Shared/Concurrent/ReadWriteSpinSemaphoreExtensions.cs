// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Concurrent.ReadWriteSpinSemaphoreExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Concurrent;

/// <summary>Set of extension methods for <see cref="T:Eco.Shared.Concurrent.ReadWriteSpinSemaphore" />.</summary>
public static class ReadWriteSpinSemaphoreExtensions
{
  /// <summary>May be used to perform disposable Read operation (between the method call and Dispose of method result).</summary>
  /// <code><![CDATA[
  /// using (semaphore.DisposableRead())
  ///     DoReadOperation();
  /// ]]></code>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ReadWriteSpinSemaphoreExtensions.ReadWriteSpinSemaphoreRead DisposableRead(
    ref this ReadWriteSpinSemaphore semaphore);

  /// <summary>May be used to perform disposable Write operation (between the method call and Dispose of method result).</summary>
  /// <code><![CDATA[
  /// using (semaphore.DisposableWrite())
  ///     DoWriteOperation();
  /// ]]></code>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static ReadWriteSpinSemaphoreExtensions.ReadWriteSpinSemaphoreWrite DisposableWrite(
    ref this ReadWriteSpinSemaphore semaphore);

  /// <summary>Disposable Read operation for <see cref="M:Eco.Shared.Concurrent.ReadWriteSpinSemaphoreExtensions.DisposableRead(Eco.Shared.Concurrent.ReadWriteSpinSemaphore@)" /> method.</summary>
  public ref struct ReadWriteSpinSemaphoreRead
  {
    private ref ReadWriteSpinSemaphore semaphore;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ReadWriteSpinSemaphoreRead(ref ReadWriteSpinSemaphore semaphore);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose();
  }

  /// <summary>Disposable Write operation for <see cref="M:Eco.Shared.Concurrent.ReadWriteSpinSemaphoreExtensions.DisposableWrite(Eco.Shared.Concurrent.ReadWriteSpinSemaphore@)" /> method.</summary>
  public ref struct ReadWriteSpinSemaphoreWrite
  {
    private ref ReadWriteSpinSemaphore semaphore;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ReadWriteSpinSemaphoreWrite(ref ReadWriteSpinSemaphore semaphore);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose();
  }
}
