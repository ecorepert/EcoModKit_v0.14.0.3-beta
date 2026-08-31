// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Players;

public static class UserUtils
{
  /// <summary>Returns true if qa mode, or admin mode is active, and the user is an admin.</summary>
  public static bool QAorAdminModeActive(this User user);

  /// <summary>Create a suffix to label a player with based on what memberships they have.</summary>
  public static string DescDemo(this User user);
}
