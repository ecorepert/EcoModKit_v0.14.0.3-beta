// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicsManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics;

/// <summary>Civics properties used on the client</summary>
public class CivicsManager : Singleton<CivicsManager>, IController, IViewController, IHasUniversalID
{
  /// <summary>Gets all the civic actions that can be executed on a given world object. Defined via attributes [AddCiviceActionToObject] and [HasCivicAction]</summary>
  public IEnumerable<Type> GetCivicActionsForWorldObject(Type worldObject);

  /// <summary>Gets all the world objects where the given civic action can be performed. Defined via attributes [AddCiviceActionToObject] and [HasCivicAction]</summary>
  public IEnumerable<Type> GetWorldObjectsForCivicAction(Type civicAction);

  public void Initialize();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
