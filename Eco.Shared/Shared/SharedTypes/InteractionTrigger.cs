// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.InteractionTrigger
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.SharedTypes;

public enum InteractionTrigger
{
  DisplayOnly = 0,
  LeftClick = 1,
  RightClick = 2,
  InteractKey = 4,
  Rotate = 8,
  MouseWheel = 16, // 0x00000010
  Stacking = 32, // 0x00000020
  MiddleClick = 64, // 0x00000040
}
