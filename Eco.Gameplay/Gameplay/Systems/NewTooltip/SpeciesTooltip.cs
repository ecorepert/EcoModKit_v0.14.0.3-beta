// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.SpeciesTooltip
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.EcopediaRoot;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Simulation.Types;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip;

[ForceCreateView]
public class SpeciesTooltip : TooltipWrapper<
#nullable disable
Species>, ILinkable, IEcopediaDynamicPageName
{
  [SyncToView(null, true)]
  public string PageName { get; }

  public static SpeciesTooltip Get(string speciesName);

  public static SpeciesTooltip Get(Species species);

  public SpeciesTooltip(Species wrapped);

  public LocString UILinkContent();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);
}
