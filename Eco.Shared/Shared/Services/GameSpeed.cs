// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.GameSpeed
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Services;

[Localized(true, false, "", false)]
public enum GameSpeed
{
  [LocDescription("120 Days until meteor hits. Very leisurely pace.")] VerySlow,
  [LocDescription("60 Days until meteor hits. Longer time at each era.")] Slow,
  [LocDescription("30 Days until meteor hits. Normal progression rate.")] Normal,
  [LocDescription("10 Days until meteor hits. Rapid progress.")] Fast,
  [LocDescription("5 Days until meteor hits. Turbo mode.")] VeryFast,
}
