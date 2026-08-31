// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[CustomRPCSetter(typeof (GameValueManager), "DynamicSetGameValue")]
[Eco.Shared.Networking.Eco(true)]
[CustomIconOnTypeTooltip(typeof (Contract))]
public abstract class GameValue : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IValidity,
  IDescribable
{
  public event PropertyChangedEventHandler PropertyChanged;

  public abstract (object Val, LocString Message) ValueAsObject(IContextObject action);

  [SyncToView(null, true)]
  public virtual string Title { get; }

  [SyncToView(null, true)]
  public virtual LocString Description();

  [SyncToView(null, true)]
  public virtual bool IsWrapped { get; }

  public virtual GameValueFlags Flags(IContextObject context);

  public virtual bool ShowStatus { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }
}
