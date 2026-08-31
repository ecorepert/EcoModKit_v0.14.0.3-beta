// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.AvatarSlotData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Gameplay;

/// <summary> Data that represents an avatar's appearance slot. </summary>
/// <remarks> Is consisted by the name and the color of the equipped item. </remarks>
[Serialized]
public struct AvatarSlotData
{
  /// <summary> For Client, this is the name of the asset, while for Server this is the item's Type. </summary>
  /// <remarks> Can be null or empty if the slot isn't filled. </remarks>
  public string Name { get; set; }

  public Dictionary<string, Color> SharedColors { get; set; }
}
