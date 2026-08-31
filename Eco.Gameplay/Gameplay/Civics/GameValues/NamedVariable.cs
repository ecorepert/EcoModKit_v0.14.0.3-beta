// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.NamedVariable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary> A form that allows users to give a name to specified float game value.
/// These names are bieng replaced with their definition during evaluation process of the formula defined in parent <see cref="T:Eco.Gameplay.Civics.GameValues.TextFormula" />. </summary>
[Serialized]
[ForceCreateView]
public class NamedVariable : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public Action OnPropertyChanged;

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Variable's text representation.")]
  public string Name { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Variable's value that will be used in calculations.")]
  public GameValue<float> Definition { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
