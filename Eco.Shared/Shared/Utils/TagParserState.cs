// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TagParserState
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.Text;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary><see cref="T:Eco.Shared.Utils.TagParser" /> state object used during call to <see cref="M:Eco.Shared.Utils.TagParser.Parse(System.String,System.Collections.Generic.Dictionary{System.String,System.ValueTuple{System.String,System.String}})" />.</summary>
internal class TagParserState
{
  /// <summary>Tracks for all open tags when processing nested tags.</summary>
  public readonly Stack<string> OpenTags;
  /// <summary>Contains parent tag attributes dictionary (only if parent tag has custom tag processor). May be <c>null</c>.</summary>
  public Dictionary<string, string>? ParentAttributes;
  /// <summary>Current Output for parsed content.</summary>
  public StringBuilder Output;
  /// <summary>Last unhandled close tag. Set when close tag doesn't match opened tag. Tag will be auto-closed in this case and closed tag reused by parent tag.</summary>
  public string? UnhandledCloseTag;
  /// <summary>Optional foldouts mapping between foldout id and it's Title and Content.</summary>
  public Dictionary<string, (string Title, string Content)>? Foldouts;

  /// <summary>Clears state and prepares it for next parse.</summary>
  public void Clear();
}
