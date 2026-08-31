// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.Vector2LinkIdTranslator
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

public class Vector2LinkIdTranslator : MappedLinkedIdTranslator<Vector2Tooltip>
{
  protected override string GetTypedLinkId(Vector2Tooltip linkTarget);

  protected override Vector2Tooltip CreateTypedLinkTarget(string linkId);
}
