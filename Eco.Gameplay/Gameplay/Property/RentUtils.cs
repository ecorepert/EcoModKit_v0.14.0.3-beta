// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RentUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Property;

public static class RentUtils
{
  public static 
  #nullable disable
  IEnumerable<WorldObject> GetObjectsCreatedByUser(this Deed deed, User user);

  public static IEnumerable<WorldObject> GetObjectsCreatedByUserExceptSettlementsStakes(
    this Deed deed,
    User user);

  public static void PackStuffIntoVoidStorage(User user, Deed deed);
}
