// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics;

[Serialized]
[ForceCreateView]
[HasIcon(null)]
public abstract class CivicAction : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IValidity,
  IDescribable,
  IRPCAuthChecks,
  ISettlementAssociated
{
  public event PropertyChangedEventHandler PropertyChanged;

  public abstract Result Perform(User user, Election election);

  public abstract LocString Description();

  public virtual LocString Failed(User user);

  public virtual LocString ElectionStarted(User user, Election election);

  public virtual Result CanEdit(User user);

  public virtual Result CanExecute(User user);

  public virtual string TableHeader { get; }

  public virtual bool NotifyOnPerform { get; }

  public virtual void ValidateParamsOnSubmit();

  [Serialized]
  [SyncToView(null, true)]
  public Settlement Settlement { get; set; }

  public virtual LocString Subject { get; }

  public virtual LocString ContainedElementName { get; }

  public virtual void Initialize(Settlement settlement);

  bool IRPCAuthChecks.IsRPCAuthorized(
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);

  /// <summary>We use this to detect when two civic actions are doing the same thing (We don't just override Equals, because in some cases we still wants two civic actions that do the same thing to not be equal.)</summary>
  public virtual bool IsSameAction(CivicAction action);

  public virtual bool IsNull();

  [DoNotNotify]
  public ref int ControllerID { get; }
}
