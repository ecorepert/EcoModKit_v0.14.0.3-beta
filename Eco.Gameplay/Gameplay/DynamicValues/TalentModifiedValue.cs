// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.TalentModifiedValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Skills;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public class TalentModifiedValue : IDynamicValue, IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  public Type TalentType { get; }

  public Talent Talent { get; }

  [SyncToView(null, true)]
  public string TalentString { get; }

  [SyncToView(null, true)]
  public string BaseTalentString { get; }

  [SyncToView(null, true)]
  public float Value { get; }

  [SyncToView(null, true)]
  public float BaseValue { get; set; }

  public float GetBaseValue { get; }

  public TalentModifiedValue(Type beneficiaryType, Type talentType, float baseValue = 1f);

  public float GetCurrentValue(IDynamicValueContext context, object obj);

  public int GetCurrentValueInt(IDynamicValueContext context, object obj, float multiplier = 1f);
}
