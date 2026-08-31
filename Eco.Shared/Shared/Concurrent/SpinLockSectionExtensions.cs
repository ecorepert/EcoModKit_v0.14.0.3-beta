// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Concurrent.SpinLockSectionExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace Eco.Shared.Concurrent;

/// <summary>Extension methods set for <see cref="T:Eco.Shared.Concurrent.SpinLockSection" />.</summary>
public static class SpinLockSectionExtensions
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static SpinLockSection EnterDisposable(ref this SpinLock spinLock);
}
