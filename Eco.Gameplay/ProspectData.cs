// Decompiled with JetBrains decompiler
// Type: ProspectData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.Math;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
public class ProspectData : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public List<ProspectItemData> Items { get; set; }

  [SyncToView(null, true)]
  public Vector3i ProspectingNormal { get; }

  [SyncToView(null, true)]
  public ToolItem Tool { get; }

  [SyncToView(null, true)]
  public int MaxBlocksCanProspect { get; set; }

  [SyncToView(null, true)]
  public int DrillDepth { get; set; }

  public ProspectData(ToolItem tool, Vector3i normal, int drillDepth);

  public ref int ControllerID { get; }
}
