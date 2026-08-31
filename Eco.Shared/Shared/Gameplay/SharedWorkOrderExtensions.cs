// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.SharedWorkOrderExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Gameplay;

public static class SharedWorkOrderExtensions
{
  public static float CompletionPercentage(this ISharedWorkOrder order);

  public static int CraftedSoFar(this ISharedWorkOrder order);

  public static float OrderPercentComplete(this ISharedWorkOrder order);

  public static float OrderPercentToCompleteNext(this ISharedWorkOrder order);

  public static float TotalCraftTime(this ISharedWorkOrder order);
}
