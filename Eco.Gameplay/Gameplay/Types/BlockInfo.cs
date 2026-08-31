// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Types.BlockInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Types;

public class BlockInfo : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public HashSet<Tag> TagsOnBlockType { get; set; }

  [SyncToView(null, true)]
  public Type CreatingItem { get; set; }

  public ref int ControllerID { get; }
}
