// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.DictionaryEnumerator`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

public class DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator
{
  public DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator);

  public object Current { get; }

  public DictionaryEntry Entry { get; }

  public object Key { get; }

  public object Value { get; }

  public bool MoveNext();

  public void Reset();
}
