// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.Work
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Math;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
public abstract class Work : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IHasWorkParty,
  IRootDescriber
{
  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public abstract string Description { get; }

  [SyncToView(null, true)]
  public abstract string DescriptionRemaining { get; }

  [SyncToView(null, true)]
  public abstract string ShortDescriptionRemaining { get; }

  [SyncToView(null, true)]
  public abstract float PercentDone { get; }

  [SyncToView(null, true)]
  public abstract Vector3i Position { get; }

  [Eco.Shared.Networking.Eco(true)]
  public bool Cancelled { get; }

  [Eco.Shared.Networking.Eco(true)]
  public int Weight { get; set; }

  public WorkParty WorkParty { get; set; }

  public IDescribable RootDescriber { get; }

  public virtual void Initialize(WorkParty parent);

  public virtual void Cancel();

  public abstract Result Valid();

  public virtual void ActionPerformed(GameAction action);

  public virtual bool ShouldOverrideAuth(GameAction action);

  public virtual void LaborerLeft(User user);

  public virtual void LaborerAddedWhileActive(User user);

  public virtual void Activate();

  public virtual void Finish();

  public ref int ControllerID { get; }
}
