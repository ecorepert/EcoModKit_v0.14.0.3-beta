// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ForceStartEndComparer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>
/// Forces a given string name to be the first in the list. The rest of the list is sorted alphabetically.
/// </summary>
/// <seealso cref="T:System.IComparable`1" />
public class ForceStartEndComparer : IComparer<string>
{
  public ForceStartEndComparer(string startString, string endString);

  public int Compare(string x, string y);
}
