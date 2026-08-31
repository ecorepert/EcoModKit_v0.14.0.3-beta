// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PropertyValues.SpecificProperty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Localization;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.PropertyValues;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("A specific deed in the world.")]
public class SpecificProperty : PropertySet, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The deed that we want to interact with.")]
  [AccessNotNeeded]
  public GameValue<Eco.Gameplay.Property.Deed> Deed { get; set; }

  public override string Describe { get; }

  public override string LandDesc(IContextObject context);

  public override Eval<IEnumerable<Eco.Gameplay.Property.Deed>> Value(IContextObject context);
}
