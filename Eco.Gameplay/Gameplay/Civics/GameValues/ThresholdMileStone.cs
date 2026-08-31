// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.ThresholdMileStone
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using JetBrains.Annotations;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[Serialized]
public sealed class ThresholdMileStone : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Eco.Shared.Networking.Eco(true)]
  [NonNegativeValue]
  public GameValue<float> Threshold { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [NonNegativeValue]
  public GameValue<float> Percent { get; set; }

  public Eval<float> GetPercentValue(IContextObject action);

  public event PropertyChangedEventHandler PropertyChanged;

  ref int IHasUniversalID.ControllerID { get; }
}
