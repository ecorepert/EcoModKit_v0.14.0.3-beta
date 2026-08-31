// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TextReaderExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Extensions for <see cref="T:System.IO.TextReader" />.</summary>
public static class TextReaderExtensions
{
  /// <summary>Read all lines to end of reader.</summary>
  public static List<string> ReadLinesToEnd(this TextReader streamReader);

  /// <summary>Read all lines to end of reader asynchronously.</summary>
  public static Task<List<string>> ReadLinesToEndAsync(this TextReader streamReader);
}
