// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ProcessorUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Utils;

public static class ProcessorUtils
{
  /// <summary>Returns number of available processors. Uses processor affinity if platform supports it (windows or linux) or <see cref="P:System.Environment.ProcessorCount" /> otherwise.
  /// Cached: the previous per-call implementation leaked a Process handle and did a native affinity query on every parallel work split.</summary>
  public static int GetAvailableProcessorCount();
}
