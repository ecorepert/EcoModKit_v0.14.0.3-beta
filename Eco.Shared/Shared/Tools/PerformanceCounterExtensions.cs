// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Tools.PerformanceCounterExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Tools;

/// <summary> Helper extension methods for <see cref="T:Eco.Shared.Tools.PerformanceCounter" />. </summary>
public static class PerformanceCounterExtensions
{
  /// <summary> Adds new value only if <see cref="P:Eco.Shared.Tools.PerformanceManager.Active" /> is <c>true</c>. Returns <c>default</c> value otherwise which won't record any metric on <see cref="M:System.IDisposable.Dispose" />"/&gt;. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static PerformanceCounterValueRef AddValueIfActive(
    this PerformanceCounter performanceCounter,
    string name = null);
}
