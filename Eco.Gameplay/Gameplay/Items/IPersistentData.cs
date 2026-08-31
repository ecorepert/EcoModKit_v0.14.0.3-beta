// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IPersistentData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> This interface is used to store data when an object is transformed into an item and to restore it afterwards. </summary>
public interface IPersistentData
{
  [Serialized]
  object PersistentData { get; set; }

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, new Type[] {})]
  LocString ContainedExample();

  [NewTooltipChildren(CacheAs.Instance, TTCat.None, TTFlags.AllowNonControllerTypeForChildren, null, new Type[] {})]
  object TooltipChildren { get; }
}
