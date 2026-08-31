// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.IDynamicValueContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.DynamicValues;

/// <summary>
/// <p>Context for evaluating Dynamic Values (passes as parameter to <see cref="M:Eco.Gameplay.DynamicValues.IDynamicValue.GetCurrentValue(Eco.Gameplay.DynamicValues.IDynamicValueContext)" />.</p>
/// <p>It provides a way to calculate <see cref="T:Eco.Gameplay.DynamicValues.IDynamicValue" /> in different contexts.</p>
/// <p>In example <see cref="T:Eco.Gameplay.DynamicValues.IDynamicValue" /> may be evaluated for <see cref="T:Eco.Gameplay.Players.User" /> - in this case you should create <see cref="T:Eco.Gameplay.DynamicValues.UserDynamicValueContext" />.</p>
/// <p>Alternatively you may need to calculate <see cref="T:Eco.Gameplay.DynamicValues.IDynamicValue" /> for crafting table <see cref="T:Eco.Gameplay.Modules.PluginModule" /> - in this case you should create <see cref="T:Eco.Gameplay.DynamicValues.ModuleContext" />.</p>
/// <p>Depending on context <see cref="T:Eco.Gameplay.DynamicValues.IDynamicValue" /> may be evaluated in different ways. In example for <see cref="T:Eco.Gameplay.DynamicValues.UserDynamicValueContext" /> <see cref="P:Eco.Gameplay.DynamicValues.IDynamicValueContext.Position" /> will be retrieved from <see cref="T:Eco.Gameplay.Players.User" />,
/// but for <see cref="T:Eco.Gameplay.DynamicValues.ModuleContext" /> it will use a crafting table position. Some values, like <see cref="T:Eco.Gameplay.DynamicValues.ModuleModifiedValue" />, may only be evaluated for specific context, otherwise they will return base value.
/// I.e. if you view Recipe from Ecopedia it will show unmodified ingredient amount and crafting time, but on crafting table it will show values modified by modules.</p>
/// </summary>
public interface IDynamicValueContext
{
  /// <summary> User for which value should be evaluated (i.e. for <see cref="T:Eco.Gameplay.DynamicValues.TalentModifiedValue" />). </summary>
  User User { get; }

  /// <summary> Position where value should be evaluated (i.e. for <see cref="T:Eco.Gameplay.DynamicValues.LayerModifiedValue" />). </summary>
  Vector3 Position { get; }
}
