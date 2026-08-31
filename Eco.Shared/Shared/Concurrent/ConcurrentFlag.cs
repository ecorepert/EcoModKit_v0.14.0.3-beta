// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Concurrent.ConcurrentFlag
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Concurrent;

/// <summary>
/// This class is implementation of thread-safe flag which can be atomically set to <c>true</c> with <see cref="M:Eco.Shared.Concurrent.ConcurrentFlag.TrySet" /> method.
/// Once set the owning thread is responsible for call to <see cref="M:Eco.Shared.Concurrent.ConcurrentFlag.Reset" /> method with returns value to <c>false</c> if needed.
/// If this flag used as publicly available property then ensure it exposed as <c>ref ConcurrentFlag Flag =&gt; ref this.flag</c> to avoid accidental struct copy
/// (in this case it will modify state of copy, not of the original flag).
/// </summary>
/// <example>
/// Typical usage is following:
/// <code>
/// ConcurrentFlag doingSomething;
/// void DoSomething()
/// {
///     if (!doingSomething.TrySet())
///         return;
///     Something();
///     doingSomething.Reset();
/// }
/// </code>
/// It is replacement for boolean flag, but with thread-safety support. Equivalent non thread-safe code will look like:
/// <code>
/// bool doingSomething;
/// void DoSomething()
/// {
///     if (!doingSomething)
///         return;
///     doingSomething = true;  // for multi-thread this flag may be already set by another thread here even if it wasn't in previous condition check
///     Something();
///     doingSomething = false;
/// }
/// </code>
/// </example>
public struct ConcurrentFlag
{
  private int flag;

  /// <summary>Tries atomically set flag. If this flag already set by another thread then the method returns <c>false</c>.</summary>
  public bool TrySet();

  /// <summary>Resets flag to not set state. Should be called after successful <see cref="M:Eco.Shared.Concurrent.ConcurrentFlag.TrySet" /> method if needed to make this flag available to be set again.</summary>
  public void Reset();
}
