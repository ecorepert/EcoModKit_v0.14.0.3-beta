// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.BlockFormData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Blocks;

public class BlockFormData : IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public FormGroup[] FormGroups { get; internal set; }

  [SyncToView(null, true)]
  public BlockForm[] BlockForms { get; internal set; }

  [SyncToView(null, true)]
  public Dictionary<int, BlockForm[]> ToolToForms { get; }

  public Dictionary<Type, BlockForm[]> TypeToForms { get; }

  public FormType[] FormTypes { get; internal set; }

  public HashSet<Type> BlockTypeHasForms { get; }
}
