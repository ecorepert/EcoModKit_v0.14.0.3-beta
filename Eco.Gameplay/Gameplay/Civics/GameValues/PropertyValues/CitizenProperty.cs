// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PropertyValues.CitizenProperty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.PropertyValues;

public abstract class CitizenProperty : PropertySet, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Property owned by this citizen.")]
  [CanAutoAssign]
  [AccessNotNeeded]
  public GameValue<IAlias> CurrentlyOwnedByCitizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Should only property that is solely owned by the specified citizen be considered? If not set, joint owned property will be chosen as well.")]
  [Advanced]
  public bool IgnorePropertyWithMulitpleOwners { get; set; }
}
