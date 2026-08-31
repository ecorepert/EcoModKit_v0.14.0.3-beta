// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ThreadSafeAction`3
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Diagnostics;

#nullable disable
namespace Eco.Core.Utils;

[DebuggerDisplay("{CallbackCount} Callbacks")]
public class ThreadSafeAction<T1, T2, T3> : ThreadSafeActionBase<Action<T1, T2, T3>>
{
  public void Invoke(T1 t1, T2 t2, T3 t3);
}
