// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.CollectResourcesWork
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
public class CollectResourcesWork : WorkOrderWork
{
  [Serialized]
  public 
  #nullable disable
  ItemTracker ItemTracker { get; set; }

  public override Vector3i Position { get; }

  public CollectResourcesWork();

  public CollectResourcesWork(WorkOrder workOrder);

  public override void Cancel();

  public override void LaborerAddedWhileActive(User user);

  public override void LaborerLeft(User user);

  public override string Description { get; }

  public override string DescriptionRemaining { get; }

  public override string ShortDescriptionRemaining { get; }

  public override float PercentDone { get; }

  public override void Activate();

  public override void Finish();

  public override void ActionPerformed(GameAction action);

  public override bool ShouldOverrideAuth(GameAction action);
}
