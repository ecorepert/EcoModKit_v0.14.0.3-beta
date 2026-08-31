// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.Cloner
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using System.Collections;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

public static class Cloner
{
  public static T Clone<T>(T source);

  public static void CopyTo(object source, object dest);

  public static void CopyList(IList sourceVal, IList destVal);

  public static IHasID CloneRegistrarElement(IHasID oldObj, string newName = null);
}
