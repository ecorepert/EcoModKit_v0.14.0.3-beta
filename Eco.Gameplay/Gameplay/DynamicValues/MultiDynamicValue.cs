// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.MultiDynamicValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public class MultiDynamicValue : IDynamicValue, IController, IViewController, IHasUniversalID
{
  public static readonly Dictionary<MultiDynamicOps, Func<IEnumerable<IDynamicValue>, IDynamicValueContext, object, float>> Operations;
  public static readonly Dictionary<MultiDynamicOps, Func<IEnumerable<IDynamicValue>, float>> BaseOperations;

  [SyncToView(null, true)]
  public MultiDynamicOps Op { get; set; }

  [SyncToView(null, true)]
  public ControllerList<IDynamicValue> Values { get; set; }

  public ref int ControllerID { get; }

  public float GetBaseValue { get; }

  public float GetCurrentValue(IDynamicValueContext context, object obj);

  public int GetCurrentValueInt(IDynamicValueContext context, object obj, float multiplier = 1f);

  public MultiDynamicValue(MultiDynamicOps op, params IDynamicValue[] values);
}
