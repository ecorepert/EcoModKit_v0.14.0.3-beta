// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CameraItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using PropertyChanged;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side item definition for the "Camera" item.</para>
/// <para>More information about ToolItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.ToolItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
/// <summary> Cameras allow users to capture and store images. </summary>
/// <remarks> It's a 'ToolItem' because it needs durability, but it doesn't interact with any other items directly. </remarks>
[Serialized]
[LocDisplayName("Camera")]
[Eco.Gameplay.Items.Weight(3000)]
[LocDescription("")]
[System.ComponentModel.Category("Hidden")]
[AddINotifyPropertyChangedInterface]
public abstract class CameraItem : 
  ToolItem,
  IGameCamera,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.True, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, Flags = InteractionFlags.NoTargetRequired)]
  public void CameraInteraction(
    #nullable disable
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [RPC]
  public bool ConsumeResources(Player player);

  [RPC]
  public Task CaptureImage(Player player, byte[] imageData);
}
