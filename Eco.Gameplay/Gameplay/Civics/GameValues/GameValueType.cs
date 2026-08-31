// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValueType
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary> Contains data about a given GameValue type, for the client to use when building its list.  </summary>
[ReadOnlyController]
[ConstantView]
public class GameValueType : IController, IViewController, IHasUniversalID, INamed
{
  [SyncToView(null, true)]
  public Type Type { get; set; }

  [SyncToView(null, true)]
  public Type ChoosesType { get; set; }

  [SyncToView(null, true)]
  public Type[] ContextRequirements { get; set; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; set; }

  [SyncToView(null, true)]
  public string Description { get; set; }

  [SyncToView(null, true)]
  public string Category { get; set; }

  public ref int ControllerID { get; }
}
