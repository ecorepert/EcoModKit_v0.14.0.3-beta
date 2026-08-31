// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.Vector2Tooltip
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

/// <summary>Used as link target for Vector2 links. Tooltips for this class are contained in <see cref="T:Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.VectorTooltipLibrary" /></summary>
[ForceCreateView]
public class Vector2Tooltip : TooltipWrapper<Vector2>, ILinkable
{
  public string Label;

  public Vector2Tooltip(Vector2 wrapped, string label = null);

  public static implicit operator Vector2Tooltip(Vector2 wrapped);

  public static implicit operator Vector2Tooltip(Vector2i wrapped);

  public static implicit operator Vector2(Vector2Tooltip parent);

  public override string ToString();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();
}
