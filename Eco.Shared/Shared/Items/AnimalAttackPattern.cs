// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.AnimalAttackPattern
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Items;

[Localized(true, false, "", false)]
public enum AnimalAttackPattern
{
  [LocDescription("Default animals behavior. Animals will attack unprovoked and defend.")] AttackNormally,
  [LocDescription("Animals would not attack unprovoked. Only defend.")] DefensiveOnly,
  [LocDescription("Animals will always flee and do not attack in any case.")] None,
}
