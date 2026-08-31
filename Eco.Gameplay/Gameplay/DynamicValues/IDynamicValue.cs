// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.IDynamicValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable enable
namespace Eco.Gameplay.DynamicValues;

[ForceCreateView]
public interface IDynamicValue : IController, IViewController, IHasUniversalID
{
  const float ValueIntEpsilon = 0.001f;

  float GetBaseValue { get; }

  float GetCurrentValue(IDynamicValueContext context, object? obj);

  int GetCurrentValueInt(IDynamicValueContext context, object? obj, float multiplier);

  float GetCurrentValue(IDynamicValueContext context);

  int GetCurrentValueInt(IDynamicValueContext context, float multiplier);

  LocString DescribeBenefits(IDynamicValueContext context, bool includeName = false);

  LocString DescribeBenefits(User user, bool includeName = false);
}
