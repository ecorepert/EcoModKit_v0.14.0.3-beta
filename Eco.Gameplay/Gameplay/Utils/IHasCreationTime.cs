// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.IHasCreationTime
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary>When creating an entity to be used with <see cref="T:Eco.Gameplay.Utils.PartitionedData`2" /> it needs to have a creation time entry
/// to determine if a new data partition should be created alongside a new entry.</summary>
public interface IHasCreationTime
{
  double TimeSeconds { get; }
}
