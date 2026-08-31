// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.IUserGameAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Stats;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Serialized]
[ForceCreateView]
public interface IUserGameAction : IController, IViewController, IHasUniversalID
{
  [ClientInterfaceProperty]
  [EssentialAggregateGrouping]
  User Citizen { get; set; }
}
