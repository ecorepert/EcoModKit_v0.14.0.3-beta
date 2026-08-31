// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.ResidencyPropertyValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Housing.PropertyValues.Internal;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

[Localized(true, false, "", false)]
[ForceCreateView]
public class ResidencyPropertyValue : StandardPropertyValue
{
  public ResidencyPropertyValue(Deed deed);

  [RPC]
  public TooltipSection ExplainedFormula();

  /// <summary>Change multiplier for difficulty and roommate penalty.</summary>
  public override float ApplyAndDescribeMultipliersAndGetNewTotal(
    float value,
    Deed deed,
    LocStringBuilder summary,
    LocStringBuilder desc);

  protected override void UpdateAndNotifyTotal(
    Deed deed,
    float newTotal,
    Vector2? weightedRoomPos,
    IEnumerable<Room> rooms);

  protected override void DescribeTotal(Deed deed, LocStringBuilder desc, LocStringBuilder summary);

  public override LocString UILinkContent();

  public override PropertyType AppliesToPropertyType { get; }

  public override string Icon { get; }
}
