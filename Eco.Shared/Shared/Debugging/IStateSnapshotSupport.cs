// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Debugging.IStateSnapshotSupport
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Debugging;

/// <summary>
/// Interface which may be used for debugging object state changes (i.e. with <see cref="M:Eco.Shared.Debugging.ActionDebugger.DebugObjectActionWithReplayOnFail``1(``0,System.Action{``0},System.Func{``0,System.Boolean})" />.
/// Object implementing the interface provides access to it's internal state via snapshots.
/// </summary>
public interface IStateSnapshotSupport
{
  protected internal object GetStateSnapshot();

  protected internal void SetStateSnapshot(object state);
}
