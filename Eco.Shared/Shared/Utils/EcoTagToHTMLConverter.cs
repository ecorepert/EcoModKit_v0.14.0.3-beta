// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.EcoTagToHTMLConverter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>Extension methods for converting Eco tag strings to HTML tag based equivilants.</summary>
public static class EcoTagToHTMLConverter
{
  /// <summary>Converts a Eco text string to a HTML string for use by Vue/HTML5</summary>
  /// <param name="input">String to convert.</param>
  /// <param name="stripFoldouts">Flag used to strip foldout tags. Defaults to false.</param>
  /// <param name="stripNonHTMLTags">Optional flag to strip all non HTML tags. Defaults to false.</param>
  /// <returns>Converted string ready for use in HTML.</returns>
  public static string ToHTML(this string input, bool stripFoldouts = false, bool stripNonHTMLTags = false);

  /// <inheritdoc cref="M:Eco.Shared.Utils.EcoTagToHTMLConverter.ToHTML(System.String,System.Boolean,System.Boolean)" />
  public static string ToHTML(this LocString input, bool stripFoldouts = false, bool stripNonHTMLTags = false);
}
