// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ReturnArrayPromise`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Buffers;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils;

public readonly struct ReturnArrayPromise<T> : IDisposable
{
  private readonly ArrayPool<T> service;
  private readonly T[] value;

  public ReturnArrayPromise(ArrayPool<T> service, T[] value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Dispose();
}
