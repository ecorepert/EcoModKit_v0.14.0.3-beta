// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.BlockTierLinkIdTranslator
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

public class BlockTierLinkIdTranslator : ObjectLinkIdTranslator<BlockTier>
{
  protected override string GetTypedLinkId(BlockTier linkTarget);

  protected override BlockTier GetTypedLinkTarget(string linkId);
}
