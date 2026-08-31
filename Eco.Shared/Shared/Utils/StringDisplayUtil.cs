// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.StringDisplayUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Text;

#nullable disable
namespace Eco.Shared.Utils;

public static class StringDisplayUtil
{
  /// <summary>Appends a header line to the <see cref="T:System.Text.StringBuilder" />. Header line represents a text centered between space characters that will always match the requested length.</summary>
  /// <param name="sb"><see cref="T:System.Text.StringBuilder" /> instance to operate on.</param>
  /// <param name="header">Header text to center on the line</param>
  /// <param name="totalLength">Total length of the header line. Defaults to 50</param>
  /// <param name="spaceCharacter">Space character used to pad the header line. Defaults to "-"</param>
  /// <returns>A reference to this instance after the append operation has completed.</returns>
  public static StringBuilder AppendHeaderLine(
    this StringBuilder sb,
    string header,
    int totalLength = 50,
    char spaceCharacter = '-');
}
