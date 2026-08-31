// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SpawnedClaims
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Settlements;

[Serialized]
public class SpawnedClaims
{
  [Serialized]
  public int SettlementClaims;
  [Serialized]
  public int Stakes;
  [Serialized]
  public int SupportClaims;

  public static SpawnedClaims operator +(SpawnedClaims left, SpawnedClaims right);
}
