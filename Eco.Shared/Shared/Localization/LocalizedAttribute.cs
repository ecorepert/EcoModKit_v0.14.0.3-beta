// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocalizedAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Localization;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class LocalizedAttribute : Attribute
{
  public bool LocalizePropertiesName { get; }

  public bool LocalizeDisplayName { get; }

  public bool ExtractPlurals { get; }

  public string CustomDisplayName { get; }

  public LocalizedAttribute(
    bool localizeMemberNames = true,
    bool localizeDisplayName = false,
    string customDisplayName = "",
    bool extractPlurals = false);
}
