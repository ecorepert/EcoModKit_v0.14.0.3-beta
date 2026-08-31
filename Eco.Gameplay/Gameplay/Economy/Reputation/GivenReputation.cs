// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.GivenReputation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation;

[Serialized]
public class GivenReputation
{
  [Serialized]
  public float GivenTotal;
  [Serialized]
  public ThreadSafeDictionary<IHasReputation, float> GivenToTarget;
  [Serialized]
  public float PositiveRepGiven;

  [OnDeserialized]
  public void Fixup();
}
