// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.UserTextures.UserTexture
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Culture;
using Eco.Gameplay.Economy.Reputation;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.UserTextures;

/// <summary>Holds the texture bytes for saving and displaying user textures, used by ViewTextureToImage on the client to display texture on UI.</summary>
[Serialized]
public class UserTexture : 
  SimpleEntry,
  IHasReputation,
  IReputationAssociated,
  IController,
  IViewController,
  IHasUniversalID,
  IGeneratesCulture
{
  [Serialized]
  public 
  #nullable disable
  string FileName;
  public Initializer Init;

  [SyncToView(null, true, Flags = SyncFlags.MustRequest | SyncFlags.ClientCached | SyncFlags.UseExtraDataChannel)]
  public byte[] TextureData { get; }

  [SyncToView(null, true)]
  public byte[] TexturePreview { get; }

  [Serialized]
  [SyncToView(null, true)]
  [Notify]
  public TextureReviewState ReviewState { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool AllowEmbeddingInText { get; }

  [SyncToView(null, true)]
  public bool NeedTMPIcon { get; set; }

  /// <summary>The value when placed in its current settlement. If no settlement is assigned, it stays at zero.</summary>
  [Notify]
  public ValResult<float> CachedArtworkValue { get; set; }

  [Notify]
  public WorldObject Holder { get; set; }

  public bool IsEmpty { get; }

  public bool IsReviewed { get; }

  public float Reputation { get; }

  [Eco.Shared.Serialization.OnPostLoad]
  public void OnPostLoad();

  public UserTexture(byte[] bytes, User user, bool allowEmbeddingInText);

  public override void Initialize();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  [TooltipAffectedBy("Holder", null, null)]
  public LocString Tooltip();

  public override LocString UILinkContent();

  public void SetTextureData(byte[] textureData);

  public void Delete();

  /// <summary>Resets texture bytes and approval state, useful for replacing portrait images without creating a new texture.</summary>
  public void Reset();

  public void SetReviewState(TextureReviewState state);

  /// <summary>Do a query to see what the value of this texture would be in the given settlement, since value depends on citizenship of the reputation givers.</summary>
  [RPC]
  public LocString ComputeArtworkValue(Player player, Settlement settlement);

  public override void Destroyed();

  User IHasReputation.UserSource { get; }

  public WorldObject TextureHolder { get; }

  Result IHasReputation.CanGiveReputation(User giver);

  float IGeneratesCulture.CultureGenerated { get; }
}
