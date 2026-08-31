// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PropertyScanning.RefSwapper
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Core.Utils;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Utils.PropertyScanning;

public static class RefSwapper
{
  public static bool SwapRefs<T>(ref T obj, Dictionary<IHasID, IHasID> refsToSwap);

  public static bool SwapRefs(this IList list, Dictionary<IHasID, IHasID> refsToSwap);

  public static bool SwapRefs<T>(
    this ThreadSafeHashSet<T> set,
    Dictionary<IHasID, IHasID> refsToSwap);

  public static bool SwapRefs<T>(
    this ControllerList<Task> list,
    Dictionary<IHasID, IHasID> refsToSwap);

  public static bool SwapRefs<T>(
    this ControllerHashSet<Task> set,
    Dictionary<IHasID, IHasID> refsToSwap);
}
