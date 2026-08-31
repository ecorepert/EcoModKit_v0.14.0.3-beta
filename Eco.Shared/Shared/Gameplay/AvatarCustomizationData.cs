// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.AvatarCustomizationData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Gameplay;

/// <summary> Customization data for a player's avatar. Used to set up starting appearance. </summary>
/// <remarks> Created by the player from the client and sent to the server on first Login.  </remarks>
[Serialized]
public struct AvatarCustomizationData
{
  public string UmaDefinition;
  public AvatarGender Gender;
  public byte[] PortraitTextureBytes;
  public int BorderSprite;
  public Color BorderColor;
  public Color BackgroundColor;

  public Dictionary<string, AvatarSlotData> DefaultAppearanceSlots { get; set; }
}
