// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValueTypeContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.View;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary> Class for a contextually specified type. </summary>
[ConstantView]
public class GameValueTypeContext : 
  GameValueType,
  IContextValue,
  IController,
  IViewController,
  IHasUniversalID
{
  public PropertyInfo Prop;
  public int EnumVal;

  [SyncToView(null, true)]
  public bool CanAutoAssign { get; set; }

  [SyncToView(null, true)]
  public bool Negated { get; set; }

  public GameValueFlags GameValueFlags { get; set; }

  public IGameValueContext MakeContext(Type targetType);

  public GameValueTypeContext Clone();

  public object GetValue(IContextObject context);

  public bool CanFill(Type containedType);
}
