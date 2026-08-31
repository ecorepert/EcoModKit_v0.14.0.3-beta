// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.AreaBonusScope
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> Where an <see cref="T:Eco.Gameplay.Components.AreaBonusComponent" />'s bonuses apply: within <see cref="P:Eco.Gameplay.Components.AreaBonusComponent.Radius" /> blocks,
/// or throughout the influence of the settlement selected on the parent's <see cref="T:Eco.Gameplay.Components.JurisdictionComponent" />.
/// Designer-controlled per building type at setup time — not player editable. </summary>
[Serialized]
public enum AreaBonusScope
{
  Radius,
  SettlementInfluence,
}
