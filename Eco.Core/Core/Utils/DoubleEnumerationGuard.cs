// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.DoubleEnumerationGuard
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>
/// Utility class which prevents double-enumeration for <see cref="T:System.Collections.IEnumerable" />. Some enumerable may not allow double enumeration which leads to invalid state and may use this class for asserts.
/// I.e. EnumerableSerializer creates enumerable for Steam. If double enumerated then Stream will return elements from current Stream read position which is invalid after first enumeration.
/// </summary>
public class DoubleEnumerationGuard : IEnumerable
{
  public DoubleEnumerationGuard(IEnumerable enumerable, string message = "Double enumeration detected which isn't allowed for this enumerable.");

  public IEnumerator GetEnumerator();
}
