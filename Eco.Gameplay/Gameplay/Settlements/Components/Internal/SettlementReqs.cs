// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.Internal.SettlementReqs
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Shared.View;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements.Components.Internal;

/// <summary>Lil helper for monitoring culture requirements of a settlement.</summary>
public class SettlementReqs : 
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  INotifyPropertyChanged
{
  [Notify]
  public bool AllPassed { get; }

  public SettlementReqs(
  #nullable disable
  Settlement settlement, StatusComponent statusComponent);

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
