// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.AdditiveStrategy
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public class AdditiveStrategy : ModificationStrategy
{
  public float[] Additions { get; }

  public AdditiveStrategy(float[] additions);

  /// <summary>
  /// Retrieves last value of this.Additions if level &gt;= this.Additions.Length
  /// For instance, this allows Skills MaxLevel to be increased over level 7 without breaking the server
  /// </summary>
  public override float ModifiedValue(float value, int level);

  public override string StyleBonusValue(float bonusValue);

  public override float BonusValue(int level);

  public override bool Increases();
}
