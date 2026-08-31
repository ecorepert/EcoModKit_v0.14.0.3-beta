// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TagParserConfig
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary> Config for <see cref="T:Eco.Shared.Utils.TagParser" /> which allows to add custom parsers and configure autocloseable tags. </summary>
public class TagParserConfig
{
  /// <summary> Tag parser looks for a custom processor for every tag it finds. The tag and its content will be left as is if there is no custom processor for it.
  /// Otherwise, everything will be replaced with the result returned by the processor. </summary>
  public readonly Dictionary<string, TagParser.CustomTagProcessor> TagNamesToCustomProcessors;
  /// <summary> Set of tags which should be automatically closed if no matching close tag was found. </summary>
  public readonly HashSet<string> AutoCloseTags;
}
