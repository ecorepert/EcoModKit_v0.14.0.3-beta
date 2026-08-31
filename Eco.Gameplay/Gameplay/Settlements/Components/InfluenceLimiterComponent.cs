// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Components.InfluenceLimiterComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Settlements.Components;

[LocDescription("Allows child settlement influence to be blocked on a property.")]
[Serialized]
[Priority(100)]
[CreateComponentTabLoc("Plots", false)]
[HasIcon(null)]
public sealed class InfluenceLimiterComponent : WorldObjectComponent
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If set, then children settlements of this settlement will not influence the given property. This can be used to make 'federal land' where town laws do not apply, even if the town would otherwise influence the area.")]
  public bool BlockChildrenSettlementsFromInfluencingProperty { get; set; }

  [RPC]
  public void SetBlockChildrenSettlementsFromInfluencingProperty(User user, bool val);
}
