// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.ITooltipSubscriptions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

public interface ITooltipSubscriptions
{
  void Subscribe(User user, TooltipPartBase part, IController controller);

  void MarkTooltipPartDirty(
    string partName,
    Type type = null,
    IController instance = null,
    User user = null,
    bool includeDerivedTypes = false,
    bool markDirtyForAllUsers = true);

  void ApplyDirtyTooltips();

  void ClearCacheForUser(User user);

  void ClearCache();
}
