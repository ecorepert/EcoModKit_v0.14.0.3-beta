// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.RoomCategoryTooltip
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

public static class RoomCategoryTooltip
{
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Tooltip(this RoomCategory cat);
}
