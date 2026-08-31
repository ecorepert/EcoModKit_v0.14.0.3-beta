// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LawSection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics.Laws;

[Eco.Shared.Networking.Eco(true)]
public class LawSection : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers,
  INotifyPropertyChanged,
  IProvidesContext,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  ICustomValidity,
  IValidity
{
  public 
  #nullable disable
  ThreadSafeAction OnIconsUpdated;

  [Eco.Shared.Networking.Eco(true)]
  public string Title { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  public string UserDescription { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The list of triggers that will cause this law to activate.  If ANY is triggerd, it will trigger the law.")]
  [HideRootListEntry]
  [AllowCopyPaste]
  public ControllerList<TriggerSettings> Triggers { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [UIListTypeName("IEnumerableHeader")]
  [AllowCopyPaste]
  public ControllerList<IfThenBlock> IfThenBlocks { get; set; }

  internal bool TriggeredBy(Type type);

  internal bool TriggeredBy(IEnumerable<Type> types);

  internal bool TriggeredBy(IHashSet types);

  public void InitializeDraft();

  [Eco.Shared.Networking.Eco(true)]
  public string Description();

  public LocString TitleAndDescription();

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; }

  public IEnumerable<string> Icons();

  /// <summary>
  /// When performaing a law section we want to allow some limited recursivity but we must make sure to prevent infinite loops.
  /// To prevent infinite loops we save the current section when it's being performed and prevent it from being performed again until it was completely done.
  ///  </summary>
  public PostResult Perform(Law law, GameAction action, AccountChangeSet acc);

  public PostResult CheckConditionsAndApplyEffects(
    Law law,
    GameAction action,
    AccountChangeSet acc);

  public Result Valid();

  public IEnumerable<LegalAction> Effects { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
