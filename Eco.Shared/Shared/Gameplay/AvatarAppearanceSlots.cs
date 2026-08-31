// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.AvatarAppearanceSlots
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Gameplay;

/// <summary> Pretty much an enum, but with a property that returns all slots in a list. </summary>
public static class AvatarAppearanceSlots
{
  public const string Head = "Head";
  public const string Shirt = "Shirt";
  public const string Pants = "Pants";
  public const string Waist = "Waist";
  public const string Shoes = "Shoes";
  public const string Back = "Back";
  public const string Face = "Face";
  public const string Hands = "Hands";
  public const string Suit = "Suit";
  public const string Hair = "Hair";
  public const string FacialHair = "FacialHair";
  public const string Body = "Body";
  public const string Eyelids = "Eyelids";
  public const string Limbs = "Limbs";
  public const string Torso = "Torso";
  public const string Hips = "Hips";
  public const string Legs = "Legs";
  public const string Feet = "Feet";

  public static List<string> AllSlots { get; }
}
