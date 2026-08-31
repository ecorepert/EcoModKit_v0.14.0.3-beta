// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Concurrent.SpinLockSection
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace Eco.Shared.Concurrent;

/// <summary>
/// Helper struct to avoid boilerplate with <see cref="T:System.Threading.SpinLock" />. Only available for .NET 7.0+ and C# 11+.
/// Normally you need to use following code:
/// <code><![CDATA[
/// bool lockTaken = false;
/// try
/// {
///     spinLock.Enter(ref lockTaken);
///     DoWithLock();
/// }
/// finally
/// {
///     if (lockTaken)
///         spinLock.Exit();
/// }
/// ]]></code>
/// but using <see cref="T:Eco.Shared.Concurrent.SpinLockSection" /> can simplify to
/// <code><![CDATA[
/// using (spinLock.EnterDisposableLock())
///     DoWithLock();
/// ]]></code>
/// </summary>
public ref struct SpinLockSection
{
  private ref SpinLock spinLock;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Dispose();
}
