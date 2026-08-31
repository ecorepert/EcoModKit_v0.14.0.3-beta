// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.Internal.StandardPropertyValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Concurrent;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Housing.PropertyValues.Internal;

/// <summary>Base class for property values derived from the regular furnishing values. Residency and cultural use this, though cultural will get separated later.</summary>
public abstract class StandardPropertyValue : 
  PropertyValue,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [SyncToView(null, true)]
  public 
  #nullable disable
  ConcurrentDictionary<Color, float> RoomSums { get; set; }

  [SyncToView(null, true)]
  public float Scale { get; set; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  protected StandardPropertyValue(Deed deed);

  public override void CalcValueAndNotify(Deed deed);

  /// <summary>Describe the final points and how they affect things.</summary>
  protected abstract void DescribeTotal(Deed deed, LocStringBuilder desc, LocStringBuilder summary);

  protected virtual void UpdateAndNotifyTotal(
    Deed deed,
    float newTotal,
    Vector2? weightedRoomPos,
    IEnumerable<Room> rooms);

  public virtual float ApplyAndDescribeMultipliersAndGetNewTotal(
    float curVal,
    Deed deed,
    LocStringBuilder summary,
    LocStringBuilder desc);
}
