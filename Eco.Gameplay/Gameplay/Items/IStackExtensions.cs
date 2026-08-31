// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IStackExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

public static class IStackExtensions
{
  public static bool Empty(this IStack stack);

  public static LocString DisplayName(this IStack stack);

  public static LocString UILink(this IStack stack);

  public static LocString UILink(this IStack stack, int multiplier);

  public static LocString UILink(this IStack stack, float quantity, int multiplier);
}
