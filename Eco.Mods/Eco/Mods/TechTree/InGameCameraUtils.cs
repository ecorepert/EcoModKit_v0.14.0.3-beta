// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.InGameCameraUtils
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.UserTextures;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

public class InGameCameraUtils
{
  public const string TripodUI = "CameraModeUITripod";
  public const string EaselUI = "CameraModeUIEasel";

  /// <summary>Creates a PictureItem using the image information and tries to add it to the player's inventory.</summary>
  public static void CaptureImage(Player player, UserTexture texture);

  public static Result ConsumeResources(Player player, Type item);
}
