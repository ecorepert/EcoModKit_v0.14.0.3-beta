// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Food.FoodVariety
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Players.Food;

public static class FoodVariety
{
  public static FoodVarietySettings Settings;

  public static (float VarietyMultiplier, string VarietyDesc) UpdateMult(
    Dictionary<Type, float> foodToCalories);
}
