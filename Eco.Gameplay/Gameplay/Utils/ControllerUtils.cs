// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.ControllerUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class ControllerUtils
{
  public static string DebugDisplay(int controllerID);

  /// <summary>Given a controller, return the type ID that is stored in ViewClassInfo. The client can use this type id too.</summary>
  public static int TypeID(this IController controller);

  public static int ControllerIDtoTypeID(int controllerID);
}
