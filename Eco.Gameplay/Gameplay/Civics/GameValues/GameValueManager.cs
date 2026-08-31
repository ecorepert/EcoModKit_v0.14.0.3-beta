// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValueManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[ConstantView]
public class GameValueManager : 
  Singleton<GameValueManager>,
  IController,
  IViewController,
  IHasUniversalID
{
  public Dictionary<(Type, string), GameValueTypeContext> TypeAndNameToContext;

  [SyncToView(null, true)]
  public Dictionary<Type, List<GameValueType>> GameValuesPerType { get; set; }

  [SyncToView(null, true)]
  public Dictionary<Type, List<GameValueTypeContext>> ContextsForType { get; set; }

  public static void InitSingleton();

  public void Init();

  public static void DynamicSetGameValue(object parent, PropertyInfo prop, object newValue);

  public static void DynamicSetGameValueActions(
    object parent,
    [ControllerPropertyName(null)] string propName,
    Type propertyType,
    object curValue,
    Action<object> setter,
    object newValue);

  public static GameValue<TContextType> MakeContext<TContextCategory, TContextType>(string name = null);

  public static List<GameValueTypeContext> GetContexts(Type type);

  public static void FixContext(ref ScanScope scope);

  public ref int ControllerID { get; }
}
