// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.DeedSalesItemData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
public class DeedSalesItemData : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Notify]
  public static ThreadSafeAction<DeedSalesItemData> ListingsChangedEvent { get; }

  [Serialized]
  [Notify]
  public string Name { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<DeedSaleListing> Listings { get; set; }

  public void Destroy();

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
