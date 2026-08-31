// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.WorldLayerSettings
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Simulation.WorldLayers.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
[ConstantView]
public class WorldLayerSettings : IController, IViewController, IHasUniversalID
{
  public List<WorldLayerComponent> Components;

  [SyncToView(null, true)]
  public string Name { get; set; }

  public string DisplayNameOverride { get; set; }

  [SyncToView(null, true)]
  public string MinimapName { get; set; }

  /// <summary>
  /// Added to work around a website issue. Represents the original name as defined in the Eco mods directory.
  /// Should be replaced with a real solution in 10.0
  /// </summary>
  public string OriginalDisplayName { get; }

  [SyncToView(null, true)]
  public float InitMultiplier { get; set; }

  [SyncToView(null, true)]
  public bool SyncToClient { get; set; }

  [SyncToView(null, true)]
  public Eco.Shared.Math.Range Range { get; set; }

  public Eco.Shared.Math.Range? OverrideRenderRange { get; set; }

  [SyncToView(null, true)]
  public Color MinColor { get; set; }

  [SyncToView(null, true)]
  public Color MaxColor { get; set; }

  [SyncToView(null, true)]
  public bool SumRelevant { get; set; }

  [SyncToView(null, true)]
  public string Unit { get; set; }

  [SyncToView(null, true)]
  public string CategoryName { get; }

  public bool Visible { get; set; }

  [SyncToView(null, true)]
  public int VoxelsPerEntry { get; set; }

  public Eco.Shared.Math.Range RenderRange { get; }

  public virtual Type LayerType { get; }

  public WorldLayerCategory Category { get; set; }

  public virtual string Subcategory { get; set; }

  public WorldLayerValueType ValueType { get; set; }

  public string AreaDescription { get; set; }

  public override string ToString();

  public void SetUnit(string unit);

  /// <summary> Returns user-friendly representation (i.e. for temperature normalized value [0; 1] it may be value in Celsius). </summary>
  public virtual float GetDisplayValue(float layerValue, bool relative = false);

  protected string GenerateAnimalSubcategory(bool isTerrestrial, string postfix);

  public ref int ControllerID { get; }
}
