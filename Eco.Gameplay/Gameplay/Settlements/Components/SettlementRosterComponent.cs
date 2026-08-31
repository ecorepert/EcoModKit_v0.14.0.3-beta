// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.SettlementRosterComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Settlements.Internal;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Settlements.Components;

/// <summary>Allows display of member settlements, applicants, etc.</summary>
[Serialized]
[CreateComponentTabLoc("Member Settlements", false)]
[HasIcon(null)]
[LocDescription("Manages the contained settlements of this settlement.")]
[PriorityAfter(new Type[] {typeof (SettlementFoundationComponent)})]
public class SettlementRosterComponent : SettlementComponent, INotifyPropertyChanged
{
  [SyncToView(null, true)]
  public override string ComponentPrefabName { get; }

  [SyncToView(null, true)]
  [Autogen]
  [DependsOn("Settlement")]
  public SettlementRoster Roster { get; }
}
