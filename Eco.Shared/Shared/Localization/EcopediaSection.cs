// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.EcopediaSection
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Xml.Linq;

#nullable disable
namespace Eco.Shared.Localization;

public class EcopediaSection
{
  public XElement Info;
  public int LocalizationID;
  public bool IsLocalizable;
  public bool HasLocTag;
  public bool IsSummary;
  public string DataType;

  public EcopediaFile FileRef { get; }

  public bool LocTagValid { get; }

  public EcopediaSection(EcopediaFile file, XElement entry);

  public void AssignLocTag(int value);

  public void RemoveLocTag();
}
