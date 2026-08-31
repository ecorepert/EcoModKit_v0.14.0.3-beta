// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Objectives
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class Objectives : 
  Singleton<Objectives>,
  IController,
  IViewController,
  IHasUniversalID,
  ISimplePluginData,
  IStorage,
  ISerializable,
  INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [RPC]
  public void SetObjective(Player player, string objective);

  public static void OpenUI(Player player);

  public string GetCategory();

  public override string ToString();

  public string GetDisplayText();

  public string GetStatus();

  public void MarkDirty();

  public void OnCreate();

  public void OnLoaded();

  [DoNotNotify]
  public ref int ControllerID { get; }

  IPersistent IStorage.StorageHandle { get; set; }
}
