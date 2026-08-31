// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ConcurrentExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Concurrent;

#nullable disable
namespace Eco.Core.Utils;

public static class ConcurrentExtensions
{
  /// <summary>
  /// Consumes maxAmount elements from <paramref name="queue" /> and returns as array.
  /// It is thread-safe if <paramref name="queue" /> is thread-safe.
  /// MaxAmount = -1 means take all elements.
  /// If will take up to number of elements as available when function called.
  /// If during function call queue consumed by other threads and in the queue less or equals elements than was when initially requested then result will contain all available elements.
  /// </summary>
  public static T[] Consume<T>(this IProducerConsumerCollection<T> queue, int maxAmount = 2147483647 /*0x7FFFFFFF*/);
}
