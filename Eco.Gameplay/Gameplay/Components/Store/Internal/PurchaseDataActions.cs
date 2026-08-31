// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Store.Internal.PurchaseDataActions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Components.Store.Internal;

public static class PurchaseDataActions
{
  public static LocString Bartered { get; }

  public static LocString Bought { get; }

  public static LocString Gave { get; }

  public static LocString Sold { get; }

  public static LocString Received { get; }

  public static LocString BoughtOrReceived(float value);

  public static LocString SoldOrGave(float value);
}
