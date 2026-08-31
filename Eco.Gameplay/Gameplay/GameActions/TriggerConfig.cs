// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.TriggerConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Laws;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Serialized]
[NonSelectable]
public abstract class TriggerConfig : GameValue<bool>, IController, IViewController, IHasUniversalID
{
  protected PropertyInfo cachedProperty;

  [Serialized]
  protected Type TypeToConfig { get; set; }

  [Serialized]
  public string PropNameBacker { get; protected set; }

  [Serialized]
  protected string PropDisplayName { get; set; }

  [SyncToView(null, true)]
  [DependsOn("PropDisplayName")]
  public string DynamicTitle { get; }

  public virtual LocString GetTriggerTooltip(LawSection section);

  public TriggerConfig();

  public TriggerConfig(Type type, PropertyInfo prop);

  public bool Matches(Type type, PropertyInfo prop);

  public bool MatchesDerived(Type type, PropertyInfo prop);

  protected object GetVal(IContextObject context);

  protected string PropName { get; }
}
