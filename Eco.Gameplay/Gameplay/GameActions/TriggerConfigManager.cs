// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.TriggerConfigManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable enable
namespace Eco.Gameplay.GameActions;

public static class TriggerConfigManager
{
  public static 
  #nullable disable
  IEnumerable<TriggerConfig> MakeConfig(Type type, IEnumerable<TriggerConfig> existingConfig);

  /// <summary> Checks if property is a valid property to appear on the Trigger section.</summary>
  public static bool IsValidConfig(PropertyInfo prop, Type type);
}
