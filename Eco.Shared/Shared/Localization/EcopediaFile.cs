// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.EcopediaFile
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

#nullable disable
namespace Eco.Shared.Localization;

public class EcopediaFile
{
  public FileInfo Info;
  public XDocument Xml;
  public string RootName;
  public string PageName;
  public string SubpageName;
  public string IconName;
  public bool CustomMerge;
  public int Priority;
  public List<EcopediaSection> Sections;

  public XElement Root { get; }

  public bool IsChapter { get; }

  public EcopediaFile(FileInfo fileInfo, XDocument xml);

  public void Save();

  public void Translate(Dictionary<int, string> locDictionary);

  public List<string> ExtractHeaderStrings();

  public string Element(string name);

  public string Attribute(string name);
}
