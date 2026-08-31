// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Internal.DestinationStacksIter
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items.Internal;

/// <summary>Base class for all destination stacks enumerators. Wraps <see cref="F:Eco.Gameplay.Items.Internal.DestinationStacksIter.nested" /> enumerator and adds <see cref="M:Eco.Gameplay.Items.Internal.DestinationStacksIter.SetSourceItem(Eco.Gameplay.Items.Item)" /> to API.</summary>
internal abstract class DestinationStacksIter : IEnumerator<ItemStack>, IEnumerator, IDisposable
{
  protected IEnumerator<ItemStack>? nested;

  /// <summary>Set source item for that destination stack enumerator. It may change an enumerator. Returns <c>true</c> if enumerator reset.</summary>
  public virtual bool SetSourceItem(Item sourceItem);

  public bool MoveNext();

  public void Reset();

  public ItemStack Current { get; }

  object IEnumerator.Current { get; }

  public void Dispose();
}
