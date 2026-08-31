// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.UserTextures.UserTextureManagerServer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems.UserTextures;

/// <summary>Holds user texture registrar and texture saving/conversion logic.</summary>
[Serialized]
public class UserTextureManagerServer : 
  Singleton<
  #nullable disable
  UserTextureManagerServer>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Serialized]
  public Registrar<UserTexture> UserTextures;
  public Initializer Init;

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<User> AdditionalReviewers { get; set; }

  [SyncToView(null, true)]
  public int UnreviewedTextureCount { get; set; }

  [SyncToView(null, true)]
  public bool IsReviewer(User user);

  [SyncToView(null, true)]
  public UserTextureConfig Config { get; }

  public void Initialize();

  public void UpdateUnreviewedTextureCount();

  /// <summary>Returns folder path to save UserTexture in.</summary>
  public static string GetFolderPath(bool isReviewed = false);

  public byte[] ReadTextureFromStorage(UserTexture texture);

  public void RemoveTextureFromRegistrar(UserTexture textureToDelete);

  /// <summary>Moves texture from unreviewed folder to reviewed folder.</summary>
  public void MoveApprovedTexture(UserTexture tex);

  /// <summary>Handles modifications to UserTexture as setting a new avatar portrait doesn't replace the old one, it only modifies the data.</summary>
  public Task SavePortraitTextureToStorage(UserTexture userTexture, byte[] textureData);

  /// <summary>Creates a new <see cref="T:Eco.Gameplay.Systems.UserTextures.UserTexture" />, adds it to registrar and returns it.</summary>
  public Task<UserTexture> CreateUserTexture(
    byte[] bytes,
    User author,
    UserTextureType userTextureType,
    bool allowEmbedding = false,
    bool needSaving = true);

  /// <summary>If this user is a reviewer - returns list of unreviewed usertextures, called from the client</summary>
  [RPC]
  public IEnumerable<UserTexture> GetTexturesToReview(User user, TextureReviewState state = TextureReviewState.Unreviewed);

  /// <summary>Gives the right to review textures to a non admin user.</summary>
  /// <param name="authorizer">Person that is giving the right to review textures.</param>
  /// <param name="recipient">User that will become a reviewer.</param>
  /// <remarks> Only Admins or Devs can do this action.</remarks>
  [RPC]
  public void AddReviewer(User authorizer, User recipient);

  /// <summary>Removes the right to review textures from a non admin user.</summary>
  /// <param name="authorizer">User that is removing the right to review textures.</param>
  /// <param name="recipient">User that will stop being a reviewer.</param>
  /// <remarks> Only Admins or Devs can do this action.</remarks>
  [RPC]
  public void RemoveReviewer(User authorizer, User recipient);

  /// <summary>Directly sets additional reviewers from provided list, used by MultiSelectorPopup on the client.</summary>
  /// <param name="users">List of users that will become reviewers, Empty if removing all reviewers.</param>
  [RPC]
  public void SetReviewers(User authorizer, List<object> users);

  /// <summary>Approves or blocks the textureToBlock.</summary>
  [RPC]
  public Task ApproveOrBlock(User user, UserTexture textureToReview, bool approved);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
