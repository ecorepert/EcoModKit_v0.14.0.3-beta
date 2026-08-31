// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.NetPositionExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils;

public static class NetPositionExtensions
{
  /// <summary> Get <see cref="T:Eco.Shared.Math.WrappedWorldPosition3" /> which is a wrapped position that makes sure it is within the world bounds, this is the preferred method to get a Position. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedPosition3 WorldPos(this INetObjectPosition netObj);

  /// <summary> Get <see cref="T:Eco.Shared.Math.WrappedWorldPosition3i" /> which is an int wrapped position that makes sure it is within the world bounds, this is the preferred method to get an int Position. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedPosition3i WorldPosInt(this INetObjectPosition netObj);

  /// <summary> Get Wrapped position but only XZ as Vector2. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Eco.Shared.Math.Vector2 WorldPosXZ(this INetObjectPosition netObj);

  /// <summary> Get Wrapped position as int and valid but only XZ as Vector2i</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i WorldPosXZi(this INetObjectPosition netObj);

  /// <summary> Gets Raw Position without checking for wrapping, not recommended to use but is available, use <see cref="M:Eco.Shared.Utils.NetPositionExtensions.WorldPos(Eco.Shared.Networking.INetObjectPosition)" /> instead when possible. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3 RawPos(this INetObjectPosition netObj);

  /// <summary> Get PlotPos directly based of the XZ position, this handles the wrapping for the position and gets proper PlotPos implicitly. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Eco.Shared.Voxel.PlotPos PlotPos(this INetObjectPosition netObj);
}
