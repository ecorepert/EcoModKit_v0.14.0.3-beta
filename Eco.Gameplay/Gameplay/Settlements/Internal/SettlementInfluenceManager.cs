// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.SettlementInfluenceManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.InfluenceObjects;
using Eco.Shared.View;
using Eco.Shared.Voxel;

#nullable enable
namespace Eco.Gameplay.Settlements.Internal;

/// <summary>Handles management of influence and related systems for all settlements.  Does all the watching and
/// notifying that makes settlements update their influence.</summary>
public class SettlementInfluenceManager : 
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public 
  #nullable disable
  InfluenceMap[] TypeToInfluenceMap { get; set; }

  public void Initialize();

  public bool InfluencedBy(Settlement settlement, PlotPos plotPos);

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
