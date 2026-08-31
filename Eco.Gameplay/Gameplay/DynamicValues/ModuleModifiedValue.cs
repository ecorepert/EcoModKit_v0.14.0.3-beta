// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.ModuleModifiedValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Gameplay.DynamicValues;

/// <summary> Dynamic value modified by Module. It retrieves the module from context and modifies value using the module. </summary>
public class ModuleModifiedValue : IDynamicValue, IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  public Type? SkillType { get; }

  public DynamicValueType ValueType { get; }

  [SyncToView("BaseValue", true)]
  public float GetBaseValue { get; }

  [SyncToView(null, true)]
  public int SkillTypeID { get; }

  [SyncToView(null, true)]
  public string ValueTypeName { get; }

  /// <summary>
  /// Initializes a new instance of the <see cref="T:Eco.Gameplay.DynamicValues.ModuleModifiedValue" /> class.
  /// </summary>
  /// <param name="baseValue">Base unmodified value.</param>
  /// <param name="skillType">Skill associated with the value.</param>
  /// <param name="valueType">Type of value (Efficiency, Speed etc).</param>
  public ModuleModifiedValue(float baseValue, Type? skillType, DynamicValueType valueType);

  public float GetCurrentValue(IDynamicValueContext context, object? obj);

  public int GetCurrentValueInt(IDynamicValueContext context, object? obj, float multiplier);
}
