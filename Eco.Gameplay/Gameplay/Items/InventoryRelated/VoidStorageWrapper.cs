// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryRelated.VoidStorageWrapper
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items.InventoryRelated;

[Serialized]
public class VoidStorageWrapper : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Serialized]
  public ControllerList<IAlias> CanAccess;

  [Eco.Shared.Networking.Eco(true)]
  public string Name { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public VoidStorageInventory Inventory { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public Vector3i Position { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float MaxXZDistance { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float MaxYDistance { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public string Icon { get; set; }

  public bool CanUserAccess(User user);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
