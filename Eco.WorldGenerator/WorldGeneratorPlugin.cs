// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.WorldGeneratorPlugin
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary>
/// This is the world generator page that is in charge of any function or configuration regarding the world.
/// <para></para>
/// <para>Information on the Terrain Editor's UI can be found in <see cref="T:Eco.WorldGenerator.UI.TerrainEditorContainer" />.</para>
/// </summary>
[LocDisplayName("WorldGeneratorPlugin")]
[Priority(-3)]
public class WorldGeneratorPlugin : 
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IServerPlugin,
  ICustomUIPlugin,
  IDisplayablePlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IInitializablePlugin
{
  public const int DimensionDivisor = 4;
  public static Action<Vector3i> SetSpawnLocation;

  public static Initializer Init { get; }

  public static WorldSettings Settings { get; }

  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public static bool IsGenerating { get; }

  public static ThreadSafeAction OnFinishGenerate { get; }

  public static ThreadSafeAction OnCompleted { get; }

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  public override string ToString();

  public string GetStatus();

  public void Initialize(TimedTask timer);

  public void CreateWorld();

  public void OnEnter();

  public object GetCustomUIControl();

  public string GetCustomUIName();

  public string GetDisplayText();

  public string GetCategory();

  public void GenerateStats();

  private struct BlockStat
  {
    public int Count;
    public string Message;
  }
}
