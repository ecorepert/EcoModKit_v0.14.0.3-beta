// Decompiled with JetBrains decompiler
// Type: Eco.Core.FileStorage.AbsolutePathAwareStorage
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.FileStorage;

/// <summary>
/// Checks if fileName is absolute path and uses file system in this case
/// otherwise it uses backing file storage.
/// </summary>
public class AbsolutePathAwareStorage : IFileStorage
{
  public AbsolutePathAwareStorage(
  #nullable disable
  IFileStorage storage);

  public string QualifiedName { get; }

  public Task<DateTime> GetLastWriteTimeAsync();

  public Task<bool> ExistsAsync();

  public string GetQualifiedName(string name);

  public Task<bool> ExistsAsync(string fileName);

  public Task<string> ReadAllTextAsync(string fileName);

  public byte[] ReadAllBytes(string fileName);

  public Task WriteAllTextAsync(string fileName, string contents);

  public Task CreateAsync(string fileName, Stream inputStream);

  public Task CopyFileToAsync(string fileName, Stream destination);

  public Task DeleteFileAsync(string fileName);

  public Task<List<string>> GetFileNamesAsync();

  public Task<bool> DirectoryExistsAsync(string dirName);

  public IFileStorage GetDirectory(string dirName);

  public Task<IFileStorage> CreateDirectoryAsync(string dirName);

  public Task DeleteDirectoryAsync(string dirName);

  public Task<IEnumerable<FileStorageDirectoryInfo>> GetDirectoriesAsync();
}
