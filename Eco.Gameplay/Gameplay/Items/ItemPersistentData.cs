// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemPersistentData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Contains the persistent data for each component and worldobject itself deriving IPersistentData, allowing that data to be preserved and
/// restored as the object is placed and put down. This is stored on the WorldObjectItem when the WorldObject is picked up, and on the WorldObject itself when it's placed.</summary>
[Serialized]
public class ItemPersistentData : 
  IPermanentDestroyHandler,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  /// <summary>Clickable tooltip section, triggers ClearOnRequest (see ResetDataTooltip).</summary>
  public 
  #nullable disable
  TextLinkButton ResetButton;

  [Serialized]
  [Notify]
  public ControllerDictionary<Type, object> Entries { get; set; }

  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public IEnumerable<IController> PersistentControllers { get; }

  /// <summary>Tries to obtain persistent data for <typeparamref name="TComponent" /> if it was previously added by <see cref="M:Eco.Gameplay.Items.ItemPersistentData.TryAddPersistentDataFromComponent(Eco.Gameplay.Items.IPersistentData)" />.</summary>
  public bool TryGetPersistentData<TComponent>([MaybeNullWhen(false)] out object data) where TComponent : IPersistentData;

  /// <summary>Sets persistent data for the component of type <typeparamref name="TComponent" />. If <paramref name="data" /> is <c>null</c> then removes component data.</summary>
  public void SetPersistentData<TComponent>(object data) where TComponent : IPersistentData;

  /// <summary>Tries to add <see cref="P:Eco.Gameplay.Items.IPersistentData.PersistentData" /> from <paramref name="component" /> if it wasn't previously added.</summary>
  public bool TryAddPersistentDataFromComponent(IPersistentData component);

  /// <summary>Tries to restore data to <see cref="P:Eco.Gameplay.Items.IPersistentData.PersistentData" /> of <paramref name="component" /> if it is in <see name="entries" />. If restored successfully then corresponding entry removed.</summary>
  public bool TryRestorePersistentDataToComponent(IPersistentData component);

  /// <summary>Internal way of cleaning. Completely removes all entries without any checks.</summary>
  internal void Clear();

  /// <summary>Cleaning requested by the player. Notifies entries with <see cref="T:Eco.Gameplay.Items.IClearRequestHandler" /> interface and removes all entries without <see cref="T:Eco.Gameplay.Items.IClearRequestHandler" />.</summary>
  public void ClearOnRequest(Player player);

  /// <summary>Removes all entries with <see cref="T:Eco.Gameplay.Items.IClearOnTrade" /> interface. It also will call <see cref="M:Eco.Gameplay.Items.IPermanentDestroyHandler.OnPermanentDestroy" /> for all such entries which implements <see cref="T:Eco.Gameplay.Items.IPermanentDestroyHandler" /> interface.</summary>
  public void ClearOnTrade();

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  /// <summary>A dialog to be shown when the reset button is clicked.</summary>
  public void ShowResetDialog(TooltipOrigin origin, TooltipClickContext context, User user);

  public void OnPermanentDestroy();

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
