// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.GroupAccumulator
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Accumulated mils per material for one output line; emits when the total reaches a whole unit.</summary>
[Serialized]
public class GroupAccumulator : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Serialized]
  [ThreadSafe]
  public Dictionary<Type, int> Materials { get; set; }

  [SyncToView(null, true)]
  public int TotalMils { get; set; }

  /// <summary>How this line is filling toward its next whole unit, as a countdown the client runs off the shared clock. Republished only when the
  /// fill rate changes or a unit is emitted, so a line that just keeps filling costs nothing to watch.</summary>
  [SyncToView(null, true)]
  public ImmutableCountdown FillTime { get; set; }

  public void RefreshTotal();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
