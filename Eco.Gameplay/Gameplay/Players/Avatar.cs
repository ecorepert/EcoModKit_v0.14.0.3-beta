// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Avatar
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.Gameplay;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class Avatar : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Serialized]
  public User Owner { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public AvatarTool ToolState { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string UmaDefinition { get; }

  [Serialized]
  [SyncToView(null, true)]
  public AvatarGender Gender { get; }

  [SyncToView(null, true)]
  public ClothingInventory Clothing { get; }

  [SyncToView(null, true)]
  public SelectionInventory Toolbar { get; }

  /// Carried item ref from carried inventory, this is always available on client and updated in both server/client on changes. Its in Avatar class since there are no need to sync it for offline users
  [SyncToView(null, true)]
  public Item CarriedItem { get; }

  [SyncToView(null, true)]
  [Notify]
  public Item HeldItem { get; }

  [SyncToView(null, true)]
  [AutoRPC]
  public string Emote { get; }

  /// <summary> Set Method for HeldItem to be able to trigger on change on every call when needed. </summary>
  public void SetHeldItem(Item value);

  public Avatar();

  public Avatar(User user);

  [RPC]
  public void SetAvatarData(AvatarCustomizationData avatarData, bool setClothes);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
