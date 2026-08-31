// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.RegistrarExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Misc;

#nullable disable
namespace Eco.Gameplay.Systems;

public static class RegistrarExtensions
{
  public static bool IsSpecial(this ISpecialRegistrarEntry entry);

  public static bool IsProposableSpecial(this IProposable entry);
}
