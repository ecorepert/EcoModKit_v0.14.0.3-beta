// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.SingleEditingUser
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class SingleEditingUser
{
  /// <summary>If no one is currently editing this object, allow the specified user to edit it.</summary>
  public static void AssignEditingUser(this ISingleEditingUser tracker, User user);

  /// <summary>Remove any user that's currently editing this object.</summary>
  public static void UnassignEditingUser(this ISingleEditingUser tracker);

  public static bool IsBeingEdited(this ISingleEditingUser tracker);
}
