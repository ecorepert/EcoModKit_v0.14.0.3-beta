// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.CollaborationLevel
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Services;

public enum CollaborationLevel
{
  [LocDescription("Lone wolf. May specialize in everything. Fast skill rate.")] NoCollaboration,
  [LocDescription("Self-Reliant Society. May specialize in most things. Medium skill rate.")] LowCollaboration,
  [LocDescription("Stable Society. May specialize in needed amount, plus extra. Normal skill rate.")] MediumCollaboration,
  [LocDescription("High-Trust Society. May specialize in needed amount, with minimal extra. Slow skill rate.")] HighCollaboration,
  [LocDescription("Solo. Recommended for single player. Gain stars from crafting actions.")] SinglePlayer,
}
