// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.IClaimStakeObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>Implemented by all objects that are used as claim stakes (I.E settlements foundations, settlements claim stakes, ...).</summary>
public interface IClaimStakeObject
{
  bool IgnoreSettlementTypeOnClaimPapers { get; set; }
}
