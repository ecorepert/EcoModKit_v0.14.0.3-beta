// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.UniversalIDTranslator
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

[Eco.Core.Utils.Priority(-200)]
public class UniversalIDTranslator : IObjectLinkIdTranslator
{
  public const int Priority = -200;

  public bool HandlesTarget(ILinkable linkTarget);

  public bool HandlesId(string linkId);

  public string GetLinkId(ILinkable linkTarget);

  public object GetLinkTarget(string linkId);
}
