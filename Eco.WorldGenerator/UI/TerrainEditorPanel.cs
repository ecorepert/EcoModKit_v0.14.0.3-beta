// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.UI.TerrainEditorPanel
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System.Windows.Forms;

#nullable disable
namespace Eco.WorldGenerator.UI;

/// <summary>The WinForm control for the Terrain Editor. WinForm control functionality is implemented here. Also see the parent UI class <see cref="T:Eco.WorldGenerator.WorldGeneratorPlugin" /></summary>
public class TerrainEditorPanel : UserControl
{
  public object Config();

  public TerrainEditorPanel(TerrainEditorContainer container, WorldGeneratorPlugin plugin);

  public void StartGenerateThread();

  /// <summary>Clean up any resources being used.</summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing);
}
