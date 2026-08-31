// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.UserTextures.UserTextureUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Mods.TechTree;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.UserTextures;

public static class UserTextureUtil
{
  public static 
  #nullable disable
  byte[] GenerateDummyJpeg(string name, int width, int height);

  /// <summary>Make a user texture created by a given user (or new test user, if not set) and fill it with random bytes.</summary>
  public static Task<UserTexture> CreateRandomUserTexture(
    int sizeMultiplier = 1,
    string name = null,
    User user = null);

  /// <summary>Make a user texture created by a given user (or new test user, if not set) and fill it with random bytes.</summary>
  public static Task<UserTexture> GenerateUserTextureWithSpecificSize(
    int width,
    int height,
    string name = null,
    User user = null);

  /// <summary>Get a picture item filled with a randomly generated image from the given user (or a new test user if null is passed)</summary>
  public static Task<PictureItem> CreateRandomPictureItem(
    int sizeMultiplier = 1,
    string name = null,
    User user = null);

  /// <summary>Get a picture item filled with a randomly generated image from the given user (or a new test user if null is passed)</summary>
  public static Task<PictureItem> CreateSpecificSizePictureItem(
    int width = 1024 /*0x0400*/,
    int height = 1024 /*0x0400*/,
    string name = null,
    User user = null);

  /// <summary> Resizes picture in jpeg format up to maxDimension x maxDimension pixels. It will respect existing ratio by lowering one of two dimensions.</summary>
  public static byte[] ResizeJPGTexture(byte[] bytes, int minDimension, int maxDimension);
}
