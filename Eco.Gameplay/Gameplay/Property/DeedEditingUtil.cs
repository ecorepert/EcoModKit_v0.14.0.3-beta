// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.DeedEditingUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Voxel;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Property;

public static class DeedEditingUtil
{
  public static 
  #nullable disable
  List<List<PlotPos>> TrySplitDeed(Deed deed, bool ensureDeleteDeeds = false, HashSet<PlotPos> oldPlots = null);

  public static Task EditInMap(Deed deed, User user);
}
