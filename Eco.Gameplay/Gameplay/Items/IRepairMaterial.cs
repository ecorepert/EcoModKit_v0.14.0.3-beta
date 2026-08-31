// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IRepairMaterial
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

public interface IRepairMaterial
{
  /// <summary>When this item is used to repair something, it will reduce the durability by this amount. This should be expressed
  /// with a decimal (.5 = 50%) and you can specify negative. This will be summed with the penalty on the repaired item itself.</summary>
  float ReducesMaxDurabilityByPercent { get; }
}
