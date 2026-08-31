// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PaintBucketItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side item definition for the "PaintBucket" item.</para>
/// <para>More information about ColorItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.ColorItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Paint Bucket")]
[Ecopedia("Items", "Products", true, true, null)]
[SalvageCost(new object[] {typeof (ChemicalWaste), 0.1f})]
[LocDescription("Mixed and ready to go, just need to apply and let dry.")]
[ItemGroup("Paint")]
public class PaintBucketItem : ColorItem
{
  public override LocString Label { get; }

  public override string ColoredOverlayName { get; }

  /// <summary> On paint bucket right click - select its color for painting</summary>
  public override string OnUsed(Player player, ItemStack itemStack);

  public override void SetRandomColor();
}
