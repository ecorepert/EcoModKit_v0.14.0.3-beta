// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.TypeTooltipExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

public static class TypeTooltipExtensions
{
  /// <summary> Generates a UILink for target object. </summary>
  /// <remarks> Automatically determines the way it should be linked based on its type and implemented interfaces. </remarks>
  public static LocString UILinkGeneric(this object obj);

  /// <summary> Generates a UILink for target type. </summary>
  /// <remarks> Assign the ID of the controller if linking an object of the type, or leave empty if linking the type itself. </remarks>
  public static LocString UILink(this Type type, int controllerID = -1, LocString? displayText = null);
}
