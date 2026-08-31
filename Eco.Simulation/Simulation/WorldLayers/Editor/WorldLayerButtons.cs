// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Editor.WorldLayerButtons
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using System.Windows.Forms;

#nullable disable
namespace Eco.Simulation.WorldLayers.Editor;

public class WorldLayerButtons : UserControl
{
  public Button TickButton;
  public CheckBox PushWorld;
  public CheckBox PullWorld;
  public Button climateButton;
  public Label StatusLabel;
  public TextBox TicksToApply;
  public Label LastTimeTicked;
  public TextBox FastForwardTime;
  public Label label1;
  public Button FastForward;
  public Button buttonJumpForward;

  /// <summary>Clean up any resources being used.</summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing);
}
