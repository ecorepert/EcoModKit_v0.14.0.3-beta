// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DataVis.NestedMeter
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.DataVis;

public class NestedMeter : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [SyncToView(null, true)]
  public LocString Name { get; set; }

  [SyncToView(null, true)]
  public float BaseVal { get; set; }

  [SyncToView(null, true)]
  public float Mutliplier { get; set; }

  [SyncToView(null, true)]
  public List<NestedMeter> SubMeters { get; set; }

  public float Val { get; }

  public NestedMeter Meter(LocString cat);

  public void Set(float baseVal, float multiplier);

  public float ComputeSums();

  public event PropertyChangedEventHandler PropertyChanged;

  public void OnPropertyChanged([ControllerPropertyName(null)] string propertyName, object before, object after);

  [DoNotNotify]
  public ref int ControllerID { get; }
}
