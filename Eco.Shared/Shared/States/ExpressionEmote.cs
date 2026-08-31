// Decompiled with JetBrains decompiler
// Type: Eco.Shared.States.ExpressionEmote
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.States;

/// <summary> Stores the various player (facial) expression emote states. </summary>
[Localized(true, false, "", false)]
public enum ExpressionEmote
{
  None = -1, // 0xFFFFFFFF
  Neutral = 0,
  Talking = 1,
  Smile = 100, // 0x00000064
  Grin = 101, // 0x00000065
  Angry = 102, // 0x00000066
  Smirk = 103, // 0x00000067
  Yawn = 104, // 0x00000068
  Frown = 105, // 0x00000069
  Chewing = 106, // 0x0000006A
  Sleep = 107, // 0x0000006B
}
