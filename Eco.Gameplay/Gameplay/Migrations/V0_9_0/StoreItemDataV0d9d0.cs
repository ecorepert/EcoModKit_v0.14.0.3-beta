// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_0.StoreItemDataV0d9d0
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_0;

[MigrationType("Eco.Gameplay.Components.StoreItemData", SinceVersion = 3.8)]
public class StoreItemDataV0d9d0
{
  [Serialized]
  public ThreadSafeList<TradeOffer> SellOffers;
  [Serialized]
  public ThreadSafeList<TradeOffer> BuyOffers;
}
