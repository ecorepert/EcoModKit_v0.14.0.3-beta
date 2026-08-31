// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.ExecutiveActions.IExecutiveAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.Laws.ExecutiveActions;

[Serialized]
[ForceCreateView]
public interface IExecutiveAction : IController, IViewController, IHasUniversalID, IDescribable
{
  PostResult PerformExecutiveAction(
    User user,
    IContextObject context,
    Settlement jurisdictionSettlement,
    AccountChangeSet acc);

  bool ContainsAction(Type type);
}
