// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.ModificationStrategy
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public abstract class ModificationStrategy
{
  public abstract float ModifiedValue(float value, int level);

  public abstract bool Increases();

  public string BonusDescription(int level);

  public abstract string StyleBonusValue(float bonusValue);

  public abstract float BonusValue(int level);
}
