// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.DiscoveryManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Items;

public class DiscoveryManager : 
  AutoSingleton<
  #nullable disable
  DiscoveryManager>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Notify]
  public static ThreadSafeAction NewItemsDiscoveredEvent { get; }

  [SyncToView(null, true)]
  public ControllerHashSet<Type> DiscoveredThings { get; }

  public IEnumerable<Item> DiscoveredItems();

  public Item GetRandomDiscoveredItem();

  public Item GetRandomDiscoveredCarriedItem();

  public Item GetRandomDiscoveredNotCarriedItem();

  public bool Discovered(Type t);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  public LocString Tooltip(Item item);

  public void UpdateDiscoveredItems();

  public void Initialize();
}
