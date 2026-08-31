// Decompiled with JetBrains decompiler
// Type: Eco.World.Water.WaterManager
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Serialization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.World.Water;

/// <summary> The main purpose of this class is to be able to send the byte data describing water level with blocks that are partially covered by water.
/// One sample of these blocks is pipes. They dont cover 100% of volume of the block.
/// The water level information is needed for the client so it can render water level properly. There are no water block here, but still it should render the water surrounding the object. </summary>
[Serialized]
public class WaterManager : AutoSingleton<WaterManager>
{
  public void Initialize();

  /// <summary>Communicates the water level of the block via byte value</summary>
  public bool TryGetExtraData(Vector3i pos, out byte extraData);

  [Serialized]
  public class WaterCacheData : IStorage, ISerializable
  {
    public IPersistent StorageHandle { get; set; }
  }
}
