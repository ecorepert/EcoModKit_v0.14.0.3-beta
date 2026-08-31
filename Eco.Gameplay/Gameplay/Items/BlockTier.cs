// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BlockTier
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

public class BlockTier : ILinkable, IController, IViewController, IHasUniversalID
{
  public static Dictionary<int, BlockTier> Tiers { get; }

  public static BlockTier GetTier(int tier);

  public int Tier { get; }

  public IEnumerable<BlockItem> ItemsInTier { get; }

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  [DoNotNotify]
  public ref int ControllerID { get; }
}
