// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.AuthItemData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Items;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
public class AuthItemData : 
  IClearOnTrade,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Notify]
  public static ThreadSafeAction<AuthItemData> ConsumersUpdatedEvent { get; }

  [Serialized]
  public ThreadSafeList<IAlias> Consumers { get; set; }

  /// <summary>Set consumers and invoke the consumers updated event.</summary>
  public void SetConsumers(IEnumerable<IAlias> consumers);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
