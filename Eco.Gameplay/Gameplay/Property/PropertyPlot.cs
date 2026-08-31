// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.PropertyPlot
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Shared.Voxel;

#nullable disable
namespace Eco.Gameplay.Property;

[Serialized]
public sealed class PropertyPlot : IDeedOwned, IController, IViewController, IHasUniversalID, IOwned
{
  public ThreadSafeAction<OwnerChangeType> OnOwnerChanged { get; }

  public ThreadSafeAction OnAuthChanged { get; }

  [Serialized]
  [SyncToView(null, true)]
  public PlotPos PlotPos { get; internal set; }

  public Vector3i CenterWorldPos { get; }

  public Vector3i CornerWorldPos { get; }

  [Serialized]
  public double LastEditTime { get; }

  public double CreationTime { get; }

  [SyncToView(null, true)]
  public Deed Deed { get; set; }

  [SyncToView(null, true)]
  public IAlias Owners { get; }

  public bool IsAuthorized(IAlias alias);

  public PropertyPlotHandle Handle { get; }

  public PropertyPlot(PlotPos plotPos);

  public override string ToString();

  [SyncToView(null, true)]
  public string FriendlyName { get; }

  [RPC]
  public void OnClick(Player clickingPlayer);

  void IDeedOwned.OnAuthChanged();

  void IDeedOwned.OnAuthSet(Deed deed);

  public Deed GetDeed();

  public ref int ControllerID { get; }
}
