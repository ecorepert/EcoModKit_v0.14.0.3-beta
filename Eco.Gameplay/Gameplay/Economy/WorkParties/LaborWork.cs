// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.LaborWork
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
public class LaborWork : WorkOrderWork
{
  public override Vector3i Position { get; }

  [Serialized]
  public GroupMarker GroupMarker { get; set; }

  public LaborWork();

  public LaborWork(WorkOrder workOrder);

  public override void Cancel();

  public override string Description { get; }

  public override string DescriptionRemaining { get; }

  public override string ShortDescriptionRemaining { get; }

  public string ShortDescNoLocation { get; }

  public override float PercentDone { get; }

  public override void Activate();

  public override void ActionPerformed(GameAction action);

  public override bool ShouldOverrideAuth(GameAction action);

  public override void LaborerAddedWhileActive(User user);

  public override void LaborerLeft(User user);

  public override void Finish();
}
