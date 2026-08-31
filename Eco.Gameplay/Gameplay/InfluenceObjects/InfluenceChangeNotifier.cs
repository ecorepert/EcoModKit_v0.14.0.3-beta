// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.InfluenceObjects.InfluenceChangeNotifier
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.InfluenceObjects;

/// <summary>Allows watching influence at a given plot position and getting a callback when changes occurr.</summary>
public class InfluenceChangeNotifier : Singleton<InfluenceChangeNotifier>
{
  /// <summary>Subscribe to Influence changes at the given position.</summary>
  /// <param name="subs">List where the subscription is stored.</param>
  public void SubscribeInfluenceChanged(
    IThreadSafeSubscriptions subs,
    PlotPos pos,
    Action callback);

  /// <summary>Called to tell us the list of changed plots and alert any subscribers.</summary>
  public void MarkInfluenceChanged(IEnumerable<PlotPos> changedPlots);

  /// <summary>Holds an influence subscription. Should stay private as its only used within this notifier</summary>
  private class InfluenceSubscription : ISubscription
  {
    public Action Callback;
    public PlotPos Pos;

    public InfluenceSubscription(PlotPos pos, Action callback);

    void ISubscription.Unsubscribe();
  }
}
