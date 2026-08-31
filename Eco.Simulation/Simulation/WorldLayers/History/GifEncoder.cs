// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.History.GifEncoder
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using System;
using System.IO;

#nullable disable
namespace Eco.Simulation.WorldLayers.History;

/// <summary>
/// Encodes multiple images as an animated gif to a stream. <br />
/// ALWAYS ALWAYS ALWAYS wire this up   in a using block <br />
/// Disposing the encoder will complete the file. <br />
/// Uses default .net GIF encoding and adds animation headers.
/// </summary>
/// 
///             Modified gifencoder from https://github.com/DataDink/Bumpkit
public sealed class GifEncoder : IDisposable
{
  public const long ColorBlockPosition = 13;
  public const int ColorBlockLength = 768 /*0x0300*/;
  public static readonly byte[] GrayColorTable;
  public bool ShareGlobalColorTable;

  public TimeSpan FrameDelay { get; set; }

  /// Encodes multiple images as an animated gif to a stream.
  ///             ALWAYS ALWAYS ALWAYS wire this in a using block
  ///             Disposing the encoder will complete the file.
  ///             Uses default .net GIF encoding and adds animation headers.
  ///             <param name="stream">The stream that will be written to.</param>
  /// <param name="repeatCount">Sets the repeat count for this gif or null to use default.</param>
  public GifEncoder(Stream stream, int? repeatCount = null);

  /// <summary>Adds a frame to this animation.</summary>
  /// <param name="frame">The frame byte array to add.</param>
  /// <param name="colorTable">The color table byte array.</param>
  /// <param name="width">Sets the width for this gif or null to use the first frame's width.</param>
  /// <param name="height">Sets the height for this gif or null to use the first frame's height.</param>
  /// <param name="x">The positioning x offset this image should be displayed at.</param>
  /// <param name="y">The positioning y offset this image should be displayed at.</param>
  /// <param name="frameDelay">The frame delay or null for default.</param>
  public void AddFrame(
    byte[] frame,
    byte[] colorTable,
    int width,
    int height,
    int x = 0,
    int y = 0,
    TimeSpan? frameDelay = null);

  public void UpdateGlobalColorTable(byte[] colorTable);

  public void AddComment(string comment);

  public void AddComment(byte[] comment);

  public void Dispose();

  public void ReOpen();
}
