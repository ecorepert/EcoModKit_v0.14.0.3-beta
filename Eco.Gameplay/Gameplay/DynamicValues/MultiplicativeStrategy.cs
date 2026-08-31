// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.MultiplicativeStrategy
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public class MultiplicativeStrategy : ModificationStrategy
{
  public float[] Factors { get; }

  public MultiplicativeStrategy(float[] factors);

  /// <summary>
  /// Retrieves last value of this.Factors if level &gt;= this.Factors.Length
  /// For instance, this allows Skills MaxLevel to be increased over level 7 without breaking the server
  /// </summary>
  public override float ModifiedValue(float value, int level);

  public override string StyleBonusValue(float bonusValue);

  public override float BonusValue(int level);

  public override bool Increases();
}
