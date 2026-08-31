// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Nutrients
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public struct Nutrients
{
  public static float MinBalancedDietMultiplier;
  public static float MaxBalancedDietMultiplier;

  [Serialized]
  [Color(4115600127)]
  public float Carbs { get; set; }

  [Serialized]
  [Color(4289593599)]
  public float Protein { get; set; }

  [Serialized]
  [Color(4291959551)]
  public float Fat { get; set; }

  [Serialized]
  [Color(2815561727)]
  public float Vitamins { get; set; }

  public float NutrientTotal();

  public float NutrientAverage();

  public IEnumerable<float> Values();

  public static Nutrients operator +(Nutrients a, Nutrients b);

  public static Nutrients operator *(Nutrients a, float val);

  public override string ToString();

  public string ToString(int pos, bool showEmpty);

  public (float Mult, string Desc) CalcBalancedDietMult();
}
