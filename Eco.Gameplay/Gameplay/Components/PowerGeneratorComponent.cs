// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PowerGeneratorComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (PowerGridComponent), null)]
[CreateComponentTabLoc("Power", false)]
[HasIcon("PowerComponent")]
[Ecopedia(null, "Power Component", false, true, null)]
public class PowerGeneratorComponent : WorldObjectComponent
{
  public static IEnumerable<IGrouping<string, Type>> AllPowerGenerators;

  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public float JoulesPerSecond { get; }

  public PowerGeneratorComponent(float joulesPerSecond);

  public PowerGeneratorComponent();

  public void Initialize(float joulesPerSecond);

  public override void Initialize();

  /// <summary> Updates the output of this Power Generator and alters the Power Grid Component to reflect the change. </summary>
  public void UpdateJoulesPerSecond(float newJoulesPerSecond);
}
