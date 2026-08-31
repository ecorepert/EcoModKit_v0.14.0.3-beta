// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.PointOfInterestList
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.View;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy;

public class PointOfInterestList : 
  IController,
  IViewController,
  IHasUniversalID,
  IEnumerable<PointOfInterest>,
  IEnumerable
{
  [SyncToView(null, true)]
  public IEnumerable<PointOfInterest> POIList(Player player);

  public PointOfInterestList();

  public PointOfInterestList(IEnumerable<PointOfInterest> list);

  public void Add(Deed deed);

  public void Add(WorldObject obj);

  public void Remove(WorldObject obj);

  public void UpdateObj(WorldObject obj);

  public IEnumerator<PointOfInterest> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public ref int ControllerID { get; }
}
