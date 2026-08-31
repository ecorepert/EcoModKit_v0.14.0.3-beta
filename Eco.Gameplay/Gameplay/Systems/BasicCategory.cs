// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.BasicCategory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems;

public class BasicCategory : 
  BasicEntry,
  ICategory,
  INamed,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public IEnumerable<INamed> Entries { get; set; }
}
