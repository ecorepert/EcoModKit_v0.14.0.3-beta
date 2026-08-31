// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.CulturalPropertyValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Housing.PropertyValues.Internal;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

/// <summary>When a property is of type 'cultural', its value will be computed with this class.</summary>
[ForceCreateView]
public class CulturalPropertyValue : StandardPropertyValue
{
  public LocString InfluenceDescription;

  public override PropertyType AppliesToPropertyType { get; }

  public override string Icon { get; }

  [SyncToView(null, true)]
  public float Influence { get; }

  [Notify]
  public float BaseInfluence { get; }

  [SyncToView(null, true, ViewType = typeof (Vector2i))]
  public Vector2i? InfluenceSourcePosition { get; }

  public CulturalPropertyValue(Deed deed);

  protected override void UpdateAndNotifyTotal(
    Deed deed,
    float newTotal,
    Vector2? weightedRoomPos,
    IEnumerable<Room> rooms);

  protected override void DescribeTotal(Deed deed, LocStringBuilder desc, LocStringBuilder summary);

  public override LocString UILinkContent();

  /// <summary>Returns true if there was a change.</summary>
  public bool SetInfluence(float influence, LocString appendix);

  public override float ApplyAndDescribeMultipliersAndGetNewTotal(
    float value,
    Deed deed,
    LocStringBuilder summary,
    LocStringBuilder desc);
}
