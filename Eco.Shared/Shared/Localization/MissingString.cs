// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.MissingString
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Localization;

/// <summary> class is used to register missing localization strings /// </summary>
public class MissingString
{
  public string String { get; set; }

  public string Stack { get; set; }

  public bool Loaded { get; set; }

  public string StringFormat { get; }

  public string StringStackFormat { get; }
}
