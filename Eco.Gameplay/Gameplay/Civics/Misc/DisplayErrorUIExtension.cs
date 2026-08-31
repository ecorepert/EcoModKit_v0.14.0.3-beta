// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.DisplayErrorUIExtension
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.View;
using System.Reflection;

#nullable enable
namespace Eco.Gameplay.Civics.Misc;

public static class DisplayErrorUIExtension
{
  public static void InitializeDisplayErrorUI(
    this 
    #nullable disable
    IDisplayErrorUI displayError,
    ISubscriptions<ThreadSafeSubscriptions> mainSubscriptions);

  /// <summary>
  /// This function will check and update IDisplayErrorUI.Errors property.
  /// </summary>
  /// <param name="displayErrorUI"></param>
  /// <param name="prop"></param>
  /// <param name="objParent"></param>
  public static void CheckAndUpdateValidity(
    this IDisplayErrorUI displayErrorUI,
    PropertyInfo prop,
    object objParent);
}
