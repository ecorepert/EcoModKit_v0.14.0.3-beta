// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.History.WorldLayerHistory
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.WorldLayers.Layers;
using System;
using System.IO;

#nullable disable
namespace Eco.Simulation.WorldLayers.History;

public class WorldLayerHistory
{
  public static string LayersDir { get; }

  public static string ImagePath(string layerName);

  public static string ImagePathCombinedHistory(string layerName);

  public static string StorageName(string layerName);

  public static string StorageNameCombinedHistory(string layerName);

  public static void Init();

  public static void InitLayerImages();

  public static void Update();

  public static void UpdateBackups();

  public static void SaveGIF(WorldLayer layer, bool backup = false);

  public static bool SaveGIF(
    string name,
    int width,
    int height,
    Func<int, int, byte> pixelFunc,
    bool animate,
    byte[] colorTable,
    bool updateColorTable,
    bool backup = false,
    bool saveHistory = true);

  public static bool SaveHeightHistory(bool backup);

  public static bool SaveTerrainHistory(bool backup);

  public static bool SaveWorldPreviewHistory(bool backup);

  public static bool InitFromStorage(string name);

  public static void Compress(
    string name,
    Stream origStream,
    Stream outStream,
    ref byte[] history,
    bool append = false);
}
