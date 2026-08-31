// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Debugging.ActionDebugger
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Debugging;

public static class ActionDebugger
{
  /// <summary>
  /// Debugs object action with state snapshot before operation and if operation fails <paramref name="isValid" /> check then resets state before the operation and replays it for debugging.
  /// It may be useful when some complex operation changes object and puts it into invalid state. You may catch such case with validation check and then be
  /// able to execute same code in debug mode on unmodified object state.
  /// <example><code><![CDATA[
  /// chunks?.DebugObjectActionWithReplayOnFail(q => this.RemoveDeliveriesFromQueues(this.chunkQueues, command.Client, chunkColumns), q => q.All(x => x.Chunk != null!));
  /// ]]></code></example>
  /// </summary>
  [Obsolete("Don't use the method in Release build. Only use it in DEBUG_ASSERTS block.")]
  public static void DebugObjectActionWithReplayOnFail<T>(
    this T obj,
    Action<T> action,
    Func<T, bool> isValid)
    where T : IStateSnapshotSupport;
}
