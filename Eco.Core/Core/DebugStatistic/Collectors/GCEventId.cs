// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.Collectors.GCEventId
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.DebugStatistic.Collectors;

/// <summary>
/// <para>Represents all supported GC event ids under Keyword 0x0000001.</para>
/// <para>These values were taken from https://docs.microsoft.com/en-us/dotnet/framework/performance/garbage-collection-etw-events</para>
/// </summary>
internal enum GCEventId
{
  GCStart = 1,
  GCEnd = 2,
  GCRestartEEEnd = 3,
  GCHeapStats = 4,
  GCCreateSegment = 5,
  GCFreeSegment = 6,
  GCRestartEEBegin = 7,
  GCSuspendEEEnd = 8,
  GCSuspendEE = 9,
  GCAllocationTick = 10, // 0x0000000A
  GCCreateconcurrentThread = 11, // 0x0000000B
  GCTerminateconcurrentThread = 12, // 0x0000000C
  GCFinalizersEnd = 13, // 0x0000000D
  GCFinalizersBegin = 14, // 0x0000000E
}
