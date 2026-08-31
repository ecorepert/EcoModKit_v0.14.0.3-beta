// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Voxel.Chunk
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Shared.Voxel;

public static class Chunk
{
  public const int Size = 10;
  public const int Area = 100;
  public const int Count = 1000;
  public const string PositionProperty = "p";
  public const string EncasementProperty = "n";
  public const string ExtraProperty = "e";
  public const string BlocksProperty = "b";
  public const string ColorProperty = "c";
  public const string PipePassThroughProperty = "pp";

  public static int Index(Vector3i localPosition);

  public static int Index(int x, int y, int z);

  /// <summary>gets the localposition given an index (1D -&gt; 3D)</summary>
  public static Vector3i Location(int index);

  public static class Encasement
  {
    public const int None = 0;
    public const int SolidEncasement = 1;
    public const int WaterEncasement = 2;
  }
}
