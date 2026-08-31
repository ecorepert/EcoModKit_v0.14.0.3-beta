// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.UI.TerrainEditorContainer
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Core.Plugins.Interfaces;
using System.Windows.Forms;

#nullable disable
namespace Eco.WorldGenerator.UI;

/// <summary>
/// The terrain editor is made up of two separate controls.
/// <para></para>
/// <para><see cref="T:Eco.WorldGenerator.UI.TerrainEditorPanel" />: This is the main panel used to interact with the terrain editor.</para>
/// PropertyGrid: This panel hosts all of the properties relating to the terrain editor.
/// </summary>
public class TerrainEditorContainer : SplitContainer, ITabPage
{
  public TerrainEditorContainer(WorldGeneratorPlugin plugin);

  public override void Refresh();

  public void OnEnter();

  public void OnLeave();

  protected override void Dispose(bool disposing);
}
