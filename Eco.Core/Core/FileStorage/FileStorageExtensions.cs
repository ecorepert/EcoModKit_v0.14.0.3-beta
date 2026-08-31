// Decompiled with JetBrains decompiler
// Type: Eco.Core.FileStorage.FileStorageExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.FileStorage;

public static class FileStorageExtensions
{
  public static 
  #nullable disable
  Task<IFileStorage> GetOrCreateDirectoryAsync(this IFileStorage fileStorage, string dirName);

  public static Task CopyFileToLocalAsync(
    this IFileStorage fileStorage,
    string fileName,
    string localFileName);

  public static Task<string> CopyFileToTempAsync(this IFileStorage fileStorage, string fileName);
}
