// Decompiled with JetBrains decompiler
// Type: Eco.Shared.States.AnimationEmote
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.States;

/// <summary> Stores the various player (body) emote states. </summary>
[Localized(true, false, "", false)]
public enum AnimationEmote
{
  None = -1, // 0xFFFFFFFF
  Neutral = 0,
  Achievement2 = 102, // 0x00000066
  Achievement3 = 103, // 0x00000067
  Knock = 401, // 0x00000191
  Cheer = 402, // 0x00000192
  Wave = 403, // 0x00000193
  Bow = 404, // 0x00000194
  Salute = 405, // 0x00000195
  Yawn = 406, // 0x00000196
  Agree = 407, // 0x00000197
  Disagree = 408, // 0x00000198
  Wonder = 409, // 0x00000199
  Clap = 410, // 0x0000019A
  Exhausted = 411, // 0x0000019B
  Shy = 412, // 0x0000019C
  Nervous = 413, // 0x0000019D
  Doh = 601, // 0x00000259
  Facepalm = 610, // 0x00000262
  Lol = 620, // 0x0000026C
  Stinky = 631, // 0x00000277
  Lie = 1001, // 0x000003E9
  Sit = 1002, // 0x000003EA
  Kneel = 1003, // 0x000003EB
  Dance1 = 2001, // 0x000007D1
  Dance2 = 2002, // 0x000007D2
}
