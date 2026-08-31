// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.ListFactory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Core.Utils;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class ListFactory
{
  public static void MakeModifyRegistrar<T>(this ControllerList<T> list) where T : class, IHasID;
}
