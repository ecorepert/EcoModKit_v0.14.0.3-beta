// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.UserTextures.UserTextureConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.UserTextures;

/// <summary>Holds UserTexture related options that can be edited from server config window.</summary>
[Localized(true, false, "", false)]
public class UserTextureConfig : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [LocDescription("Max allowed size for user uploaded textures in Kilobytes, default is 400 KB")]
  public int MaxAllowedTextureSizeInKB { get; set; }

  [LocDescription("Max dimension allowed for user texture, default is 512 pixels (allowing textures up to 512x512 pixels)")]
  [SyncToView(null, true)]
  public int MaxDimensionOfUserTexture { get; set; }

  [SyncToView(null, true)]
  public int MaxAllowedTextureSizeInBytes { get; }

  [SyncToView(null, true)]
  [LocDescription("Should newly submitted textures from the users's storage wait be automatically approved displaying them? This is a layer of protection against displaying inappropriate images to the players, and should stay disabled on public servers.")]
  public bool AutoApprovePrinterPictures { get; set; }

  [SyncToView(null, true)]
  [LocDescription("Should newly avatar portrait textures be automatically approved? This is a layer of protection against displaying inappropriate images to the players.")]
  public bool AutoApproveAvatarPictures { get; set; }

  [SyncToView(null, true)]
  [LocDescription("Should newly in game photos wait be automatically approved? This is a layer of protection against displaying inappropriate images to the players.")]
  public bool AutoApproveInGamePhoto { get; set; }

  [SyncToView(null, true)]
  [LocDescription("Should users be able to upload texture")]
  public bool AllowTextureUpload { get; set; }

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
