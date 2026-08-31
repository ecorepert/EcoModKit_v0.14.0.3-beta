// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.WorldLayerEditor
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Math;
using System.Windows.Forms;

#nullable disable
namespace Eco.WorldGenerator;

public class WorldLayerEditor : SplitContainer, ITabPage
{
  public float PanelWidth;
  public Vector2 PercentPos;

  protected override void InitLayout();

  public void OnEnter();

  public void OnLeave();

  public void Clear();

  public void BuildLayers();

  public void SetEditObject(object value);

  protected override void Dispose(bool disposing);
}
