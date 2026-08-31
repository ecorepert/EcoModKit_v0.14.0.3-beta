// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Buffs.AreaBuffOverlay
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Gameplay;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.UI;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Buffs;

public class AreaBuffOverlay : 
  IController,
  IViewController,
  IHasUniversalID,
  IHeatMapOverlay,
  IOverlayWithDescribableUnits,
  IMinimapOption,
  IMinimapCategorizedOption
{
  [SyncToView(SyncFlags.MustRequest)]
  public Array2D<float> Map { get; set; }

  [SyncToView(null, true)]
  public Range Range { get; set; }

  [SyncToView(null, true)]
  public string OverlayName { get; set; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; set; }

  [SyncToView(null, true)]
  public string FolderStructure { get; set; }

  [SyncToView(null, true)]
  public float Priority { get; }

  [SyncToView(null, true)]
  public bool IsOnByDefault { get; }

  [SyncToView(null, true)]
  public List<IAreaBuffer> ContainedBuffs { get; set; }

  [SyncToView(null, true)]
  public LocString UnitDescription { get; }

  [SyncToView(null, true)]
  public string Name { get; }

  public void Render(IEnumerable<IAreaBuffer> buffs);

  public ref int ControllerID { get; }
}
