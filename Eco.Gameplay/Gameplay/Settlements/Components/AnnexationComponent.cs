// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.AnnexationComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Settlements.Annexation;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Settlements.Components;

[LocDisplayName("Annexation")]
[LocDescription("Manages the relationship between this settlement and other settlements.")]
[Serialized]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
[Ecopedia("Settlements", "Annexation", false, true, null)]
[RequireComponent(typeof (JurisdictionComponent), null)]
[RequireComponent(typeof (LinkComponent), null)]
[RequireComponent(typeof (InOutLinkedInventoriesComponent), null)]
public class AnnexationComponent : 
  WorldObjectComponent,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  public static ThreadSafeAction<Settlement> AnnexInventoryUpdatedEvent;

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("GeneralHeader")]
  public LocString Title { get; }

  [SyncToView(null, true)]
  [Autogen]
  [PropReadOnly]
  [UITypeName("StringDisplay")]
  [DependsOnSubMember("Settlement", "MarkedUpName")]
  public LocString SubTitle { get; }

  [SyncToView(null, true)]
  [Autogen]
  [Locked]
  [HideRoot]
  [DependsOnMember("Settlement")]
  public IEnumerable<AnnexationRecord> Annexations { get; }

  public override void Initialize();

  public override void PostInitialize();

  public LocString DoSubtitle();
}
