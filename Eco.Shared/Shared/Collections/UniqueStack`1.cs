// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.UniqueStack`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Collections;

/// <summary> Thread-unsafe Unique Stack implementation. It only allows to put unique elements. </summary>
public class UniqueStack<TItem>
{
  public int Count { get; }

  /// <summary> Push new item . Item ignored if already present in stack and method returns false in this case. </summary>
  public bool Push(TItem item);

  public TItem Pop();

  public TItem Peek();

  /// <summary> Tries to pop item from the stack (if any). Returns <c>true</c> and item output parameter, <c>false</c> otherwise. </summary>
  public bool TryPop(out TItem item);

  /// <summary> Clears whole stack. </summary>
  public void Clear();
}
