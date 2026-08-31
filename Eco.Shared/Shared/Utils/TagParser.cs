// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TagParser
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Parses XML-like text using custom tag processors from config. Tag processor is a <see cref="T:Eco.Shared.Utils.TagParser.CustomTagProcessor" /> delegate.</summary>
public class TagParser
{
  /// <summary>Parser for autoclosing tags only (e.g. color tags in titles).</summary>
  public static readonly TagParser AutoCloseTagsParser;

  public TagParser();

  public TagParser(TagParserConfig config);

  /// <summary>Parses <paramref name="text" /> using registered custom processors and fixing any unclosed tags (defined to be auto-closed).</summary>
  public string Parse(
    string text,
    Dictionary<string, (string Title, string Content)>? context = null);

  /// <summary>Processing callback for custom tags.</summary>
  /// <param name="paramNamesToValues">Parameters of the tag and their values (see sample below). This dictionary will be used as parentAttrs for child tags. See how ProcessFoldoutMatch on client side looks for parameters that were added by its children.</param>
  /// <param name="content">&lt;someTag parameter="value"&gt;content&lt;/someTag&gt;</param>
  /// <param name="parentAttrs">paramNamesToValues of the parent tag. See how ProcessFoldoutTitle on the client side passes data to its parent foldout tag.</param>
  /// <param name="foldouts">Optional foldouts mapping provided in <see cref="M:Eco.Shared.Utils.TagParser.Parse(System.String,System.Collections.Generic.Dictionary{System.String,System.ValueTuple{System.String,System.String}})" /> call. May be null.</param>
  public delegate string CustomTagProcessor(
    Dictionary<string, string>? paramNamesToValues,
    string content,
    Dictionary<string, string>? parentAttrs,
    Dictionary<string, (string Title, string Content)>? foldouts);
}
