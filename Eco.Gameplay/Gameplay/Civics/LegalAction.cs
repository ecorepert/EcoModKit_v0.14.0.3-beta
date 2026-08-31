// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.LegalAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics;

[Eco.Shared.Networking.Eco(true)]
[HasIcon(null)]
[LocDescription("An action to take when a law is triggered.")]
public abstract class LegalAction : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IValidity,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [Advanced]
  [LocDescription("Display success notice as popup.")]
  public GameValue<bool> InfoboxOnSuccess { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public abstract LocString Description();

  public PostResult PerformAndProcessResult(Law law, GameAction action, AccountChangeSet acc);

  protected abstract PostResult Perform(Law law, GameAction action, AccountChangeSet acc);

  public ref int ControllerID { get; }

  public virtual bool ContainsAction(Type type);

  public virtual LocString DescribeForNotification(Law law, GameAction action);
}
