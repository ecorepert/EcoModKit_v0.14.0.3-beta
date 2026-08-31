// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Dirtyable`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Utils;

/// <summary>Helps to track value dirty state. When <see cref="P:Eco.Core.Utils.Dirtyable`1.Value" /> assigned and if it not equals to previous value then <see cref="F:Eco.Core.Utils.Dirtyable`1.Dirty" /> flag sets.</summary>
public struct Dirtyable<T>
{
  private T value;
  public bool Dirty;

  public T Value { get; set; }

  public Dirtyable(T value);

  /// <summary>Tries to get dirty value (if value is <see cref="F:Eco.Core.Utils.Dirtyable`1.Dirty" />) and then clears <see cref="F:Eco.Core.Utils.Dirtyable`1.Dirty" /> flag. Returns <c>false</c> if value wasn't dirty. Outputs current value in <paramref name="currentValue" /> no matter of return value.</summary>
  public bool TryGetDirtyValueAndClear(out T currentValue);

  public static implicit operator T(Dirtyable<T> dirtyable);

  public static implicit operator Dirtyable<T>(T value);
}
