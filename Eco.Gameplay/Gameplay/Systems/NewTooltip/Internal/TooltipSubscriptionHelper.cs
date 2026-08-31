// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.Internal.TooltipSubscriptionHelper
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using System;
using System.Reflection;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.Internal;

public static class TooltipSubscriptionHelper
{
  /// <summary>Create tooltip invalidation action for tooltip part generated with <paramref name="method" /> marked with <see cref="T:Eco.Core.PropertyHandling.TooltipAffectedByAttribute" />.</summary>
  public static 
  #nullable disable
  PropertyChangedBeforeAfterEventHandler CreateTooltipInvalidationAction(
    Type type,
    MethodInfo method);
}
