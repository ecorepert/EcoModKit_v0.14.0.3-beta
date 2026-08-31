// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.WorkOrderWork
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
public abstract class WorkOrderWork : Work
{
  [Eco.Shared.Networking.Eco(true)]
  public WorkOrder Order { get; set; }

  public WorkOrderWork();

  public WorkOrderWork(WorkOrder workOrder);

  public override void Initialize(WorkParty parent);

  public override void Finish();

  public override Result Valid();

  public override bool ShouldOverrideAuth(GameAction action);

  public string CategoryText { get; }
}
