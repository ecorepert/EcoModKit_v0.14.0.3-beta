// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ISnapshotable`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>Interface which may be implemented by collection which supports snapshots of elements (this snapshot is safe to use in thread-safe environment).</summary>
public interface ISnapshotable<T>
{
  ICollection<T> Snapshot { get; }
}
