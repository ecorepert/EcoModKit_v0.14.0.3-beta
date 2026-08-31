// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitutional.CivicConditionBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.Constitutional;

[Serialized]
public abstract class CivicConditionBase : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IValidity,
  IDescribable
{
  public abstract LocString Description();

  public abstract bool AppliesTo(CivicAction action);

  public abstract bool AppliesTo(Type type);

  public virtual bool UndercutAllPriorities { get; }

  public abstract IEnumerable<Type> AllTypes { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
