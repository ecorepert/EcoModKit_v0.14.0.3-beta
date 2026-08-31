// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.Payment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
public abstract class Payment : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  ICustomValidity,
  IValidity,
  IHasWorkParty,
  IRootDescriber
{
  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public abstract string Description { get; }

  public ref int ControllerID { get; }

  public WorkParty WorkParty { get; set; }

  public IDescribable RootDescriber { get; }

  public abstract string WorkPerformed(Laborer laborer, float percentPerformed);

  public virtual string WorkFinished();

  public abstract Result Valid();

  public abstract void OnActivated();

  public abstract string ShortDescription();

  public virtual void Posted(User user);

  public virtual void Initialize(WorkParty parent);
}
