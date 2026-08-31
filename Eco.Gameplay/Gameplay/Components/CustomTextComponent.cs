// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CustomTextComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[LocDescription("Set the text to display on this sign.")]
[HasIcon(null)]
public class CustomTextComponent : WorldObjectComponent, IPersistentData, INotifyPropertyChanged
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public TextItemData TextData { get; set; }

  [Serialized]
  public User LastEditedBy { get; set; }

  public object PersistentData { get; set; }

  public void Initialize(int maxLength);

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();

  [RPC]
  public bool SetText(Player player, string text);
}
