// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Aliases.AliasRegistrarCategory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Aliases;

[ForceCreateView]
public class AliasRegistrarCategory : 
  ICategory,
  INamed,
  IController,
  IViewController,
  IHasUniversalID
{
  public IRegistrar Registrar { get; }

  public AliasRegistrarCategory();

  public AliasRegistrarCategory(Type type);

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<INamed> Entries { get; }

  public LocString Description { get; }

  public IAlias GetAlias(int id);

  public ref int ControllerID { get; }
}
