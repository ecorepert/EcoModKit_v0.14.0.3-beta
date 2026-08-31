// Decompiled with JetBrains decompiler
// Type: Eco.Shared.EmoteCategory
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared;

/// <summary> Emote category definition to have some config variables for categories, like priority </summary>
public class EmoteCategory
{
  public string ID { get; }

  public string Name { get; }

  public int Priority { get; }

  public EmoteCategory(LocString localizedName, int priority = 0);
}
