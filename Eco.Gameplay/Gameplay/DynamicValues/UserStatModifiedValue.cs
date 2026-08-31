// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.UserStatModifiedValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public class UserStatModifiedValue : IDynamicValue, IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public float Value { get; set; }

  public UserStatType StatType { get; set; }

  public ref int ControllerID { get; }

  public UserStatModifiedValue(UserStatType type, User user, Action callback);

  public float GetBaseValue { get; }

  public float GetCurrentValue(IDynamicValueContext context, object obj);

  public int GetCurrentValueInt(IDynamicValueContext user, object obj, float multiplier = 1f);
}
