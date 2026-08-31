// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.DirtyFlag
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>Handles tracking a dirty state, and now allowing to 'SetDirty' while its in the process of being updated. This way, if a dirty flag tries
/// to set while its doing the dirty processing, it will make it dirty even after dirty processing complete.</summary>
public struct DirtyFlag
{
  private const int Clear = 0;
  private const int Set = 1;
  private const int Unsetting = 2;
  private int dirty;

  /// <summary>Set the flag dirty, taking care of multithreading where the dirty processing may be happening concurrently.</summary>
  public void SetDirty();

  /// <summary>If dirty, execute the action, then clear the dirty flag.</summary>
  public void IfDirty(Action action);

  /// <summary>Tries to start update for <see cref="T:Eco.Core.Utils.DirtyFlag" />. Returns <c>false</c> if flag isn't set and update not needed.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public bool TryStartUpdate();

  /// <summary>Finishes update started with <see cref="M:Eco.Core.Utils.DirtyFlag.TryStartUpdate" />. Clears the flag if it wasn't <see cref="M:Eco.Core.Utils.DirtyFlag.SetDirty" /> during the update.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void FinishUpdate();

  /// <summary>Clear without processing.</summary>
  public void ClearFlag();

  public static implicit operator bool(DirtyFlag flag);
}
