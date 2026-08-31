// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Async.DelayedActionManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization;
using System;

#nullable disable
namespace Eco.Core.Utils.Async;

public static class DelayedActionManager
{
  public static IPersistent StorageHandle { get; set; }

  public static void RemoveDelayedAction(Action action);

  public static void AddDelayedAction(Action action, int delayMs, bool overrideExisting = false);
}
