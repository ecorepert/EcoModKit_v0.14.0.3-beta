// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.IfThenBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics;

[Serialized]
public class IfThenBlock : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IValidity,
  IHasClientControlledContainers
{
  [Eco.Shared.Networking.Eco(true)]
  [HideRoot]
  [LocCategory("The tests made to apply this effect.")]
  public 
  #nullable disable
  SetOfConditions If { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocCategory("The results if the conditions for this block are met.")]
  [UIListTypeName("IEnumerableHeader")]
  [AllowCopyPaste]
  public ControllerList<LegalAction> Then { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  [AutoRPC]
  public bool ElseChosen { get; set; }

  public IfThenBlock();

  public IfThenBlock(LegalAction action);

  public LocString DescribeFull(bool isElse);

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public PostResult TryPerform(
    Law law,
    GameAction action,
    AccountChangeSet acc,
    LawSection section,
    int index,
    LocStringBuilder sbDebug);

  public enum Position
  {
    First,
    Middle,
    Last,
  }
}
