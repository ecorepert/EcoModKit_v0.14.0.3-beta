// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.DirectionAxisFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Math;

[Flags]
public enum DirectionAxisFlags
{
  Right = 1,
  Left = 4,
  Forward = 2,
  Backward = 8,
  Up = 16, // 0x00000010
  Down = 32, // 0x00000020
  X = Left | Right, // 0x00000005
  Y = Down | Up, // 0x00000030
  Z = Backward | Forward, // 0x0000000A
  All = Z | Y | X, // 0x0000003F
  None = 0,
}
