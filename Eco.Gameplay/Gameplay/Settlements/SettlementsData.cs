// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementsData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Gameplay.InfluenceObjects;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Settlements;

[Serialized]
public class SettlementsData : Singleton<SettlementsData>, IStorage, ISerializable
{
  [Serialized]
  public Registrar<Settlement> Settlements;
  [Serialized]
  public SettlementManager SettlementManager;
  public InfluenceManager InfluenceManager;

  [Eco.Shared.Serialization.OnPostLoad]
  public void OnPostLoad();

  public IPersistent StorageHandle { get; set; }
}
