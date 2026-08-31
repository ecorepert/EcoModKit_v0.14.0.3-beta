// Decompiled with JetBrains decompiler
// Type: Eco.Shared.UI.MultiSelectorPopUpFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.UI;

/// <summary> Flags for customizing The MultiSelector Pop up behavior. </summary>
[Flags]
public enum MultiSelectorPopUpFlags : byte
{
  None = 0,
  AllowMultiSelect = 1,
  ShowCategories = 2,
  AllowEmptySelect = 4,
  AllowQuantitySelect = 8,
}
