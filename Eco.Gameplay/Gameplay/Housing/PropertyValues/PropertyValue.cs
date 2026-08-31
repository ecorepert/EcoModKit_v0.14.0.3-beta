// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.PropertyValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Housing.PropertyValues;

/// <summary>Determines the property value of a given deed, given whats built on it.</summary>
public abstract class PropertyValue : UnserializedEntry
{
  protected 
  #nullable disable
  List<Room> rooms;

  [SyncToView(null, true)]
  public LocString Title { get; set; }

  [SyncToView(null, true)]
  public LocString Description { get; set; }

  [SyncToView(null, true)]
  public LocString Summary { get; set; }

  [SyncToView(null, true)]
  public LocString Appendix { get; set; }

  [SyncToView(null, true)]
  [Notify]
  public float Value { get; protected set; }

  public Deed Deed { get; }

  public PropertyValue(Deed deed);

  public IEnumerable<Room> Rooms { get; }

  public abstract PropertyType AppliesToPropertyType { get; }

  public abstract string Icon { get; }

  public void SetRooms(IEnumerable<Room> rooms);

  /// <summary> Calculate the value of the property.</summary>
  public abstract void CalcValueAndNotify(Deed deed);
}
