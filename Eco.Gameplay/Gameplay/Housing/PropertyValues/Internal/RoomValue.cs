// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.Internal.RoomValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues.Internal;

public abstract class RoomValue : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public abstract PropertyType AppliesToPropertyType { get; }

  public abstract void CalculateValue(RoomStats roomStats);

  public abstract float Value { get; }

  public virtual LocString Title { get; }

  public virtual LocString TitleLink { get; }

  [Notify]
  public LocString Description { get; set; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
