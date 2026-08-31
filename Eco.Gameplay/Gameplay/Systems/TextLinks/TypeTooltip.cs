// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.TypeTooltip
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

[ForceCreateView]
public class TypeTooltip : TooltipWrapper<Type>, ILinkable
{
  public TypeTooltip(Type wrapped);

  public int ViewClassID { get; }

  public static implicit operator TypeTooltip(Type wrapped);

  public static implicit operator Type(TypeTooltip parent);

  public override string ToString();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public IController SpecificChildren { get; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public LocString TypeInfo { get; }
}
