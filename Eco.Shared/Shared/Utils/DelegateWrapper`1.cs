// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.DelegateWrapper`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>
/// Intended to be used as base class for delegate wrapper which implements some interface.
/// It implements equality operations and holds delegate references.
/// It helps to avoid creating similar classes only differing by interface method implementation.
/// </summary>
/// <example>
/// This sample shows how it may be used with <see cref="T:System.IComparable`1" /> interface.
/// <code>
/// class IntComparableWrapper : DelegateWrapper&lt;Func&lt;int, int&gt;&gt;, IComparable&lt;int&gt;
/// {
///    public IntComparableWrapper(Func&lt;int, int&gt; func) : base(func) { }
///    int CompareTo(int value) =&gt; this.Delegate(value);
/// }
/// </code>
/// </example>
public abstract class DelegateWrapper<T> where T : System.Delegate
{
  protected readonly T Delegate;

  protected DelegateWrapper(T @delegate);

  public sealed override bool Equals(object obj);

  public sealed override int GetHashCode();
}
