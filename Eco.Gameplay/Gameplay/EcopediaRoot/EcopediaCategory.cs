// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.EcopediaRoot.EcopediaCategory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.EcopediaRoot;

[ConstantView]
public class EcopediaCategory : 
  IEcopediaTab,
  IPrioritizedPage,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public Dictionary<string, EcopediaPage> Pages { get; set; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public LocString DisplayName { get; set; }

  [SyncToView(null, true)]
  public string ChapterName { get; set; }

  [SyncToView(null, true)]
  public string IconName { get; set; }

  [SyncToView(null, true)]
  public string Summary { get; set; }

  [SyncToView(null, true)]
  public float Priority { get; set; }

  [SyncToView(null, true)]
  public int DiscoveredItem { get; set; }

  [SyncToView(null, true)]
  public string FullName { get; set; }

  public ref int ControllerID { get; }
}
