// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PickerProperty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Amazon.MissingTypes;
using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary> A picker that targets a property. Contract clauses use this to determine the target of their operation.</summary>
/// <remarks> e.g.: "Gather 10 Tomatoes from SomeUserFarm". This is what's used to select "SomeUserFarm". </remarks>
[Serialized]
public class PickerProperty : Picker, ICloneable
{
  [SyncToView(null, true)]
  public override string Choice { get; }

  public string ChoiceNoDescription { get; }

  public override Deed Deed { get; }

  public override bool IsSet { get; }

  public PickerProperty();

  public PickerProperty(string cat, string desc);

  public override void SetLocation(Player player, PointOfInterest obj);

  public override Result ValidOwnership(string pickerName, User user);

  public void ForceLocation(WorldObject worldObject);

  public void ForceLocation(Vector3 worldPosition);

  public void ReplaceMarker(Vector3i newMarkerPos, string newDescription);

  public object Clone();
}
