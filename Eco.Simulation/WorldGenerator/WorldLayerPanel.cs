// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.WorldLayerPanel
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.WorldLayers.Layers;
using System.Windows.Forms;

#nullable disable
namespace Eco.WorldGenerator;

public class WorldLayerPanel : UserControl
{
  public bool Maxed;
  public int StartingWidth;
  public int StartingHeight;
  public WorldLayer Layer;
  public PictureBox LayerPictureBox;
  public Label LabelLayer;
  public Button MaximizeButton;

  protected override bool ScaleChildren { get; }

  /// <summary>Clean up any resources being used.</summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing);
}
