// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.RoomTier
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

public class RoomTier
{
  public float TierVal;
  public float SoftCap;
  public float HardCap;
  public float DiminishingReturnPercent;
  public LocString Description;

  public Eval<float> ApplyToValue(float inVal);
}
