// Decompiled with JetBrains decompiler
// Type: Eco.Shared.EditableObjectInCollection`2
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared;

public abstract class EditableObjectInCollection<T, TItem> : 
  IEditableObjectInCollection<T>,
  IEditableObjectInCollection
  where T : EditableObjectInCollection<T, TItem>, new()
{
  protected static Dictionary<Type, T> Mapping { get; }

  public Type Type { get; set; }

  public static implicit operator Type(EditableObjectInCollection<T, TItem> itemType);

  public IEnumerable<T> GetCollection();

  public override string ToString();

  public override bool Equals(object obj);

  public override int GetHashCode();

  public bool IsEmpty { get; }

  IEnumerable IEditableObjectInCollection.GetCollection();
}
