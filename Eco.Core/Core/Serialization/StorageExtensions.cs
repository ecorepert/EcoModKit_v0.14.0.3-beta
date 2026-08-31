// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.StorageExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization;

public static class StorageExtensions
{
  /// <summary>Perform storage modification. It ensures it won't be modified or saved in another thread to prevent concurrency issues.</summary>
  public static void Modify<T>(this T storage, Action<T> action) where T : IStorage;

  /// <summary>Perform storage modification (version with return value). It ensures it won't be modified or saved in another thread to prevent concurrency issues.</summary>
  public static TResult Modify<T, TResult>(this T storage, Func<T, TResult> action) where T : IStorage;

  public static void SaveAll(this IStorage storage);
}
