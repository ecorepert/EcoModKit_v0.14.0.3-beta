// Decompiled with JetBrains decompiler
// Type: Eco.Core.FileStorage.IFileStorage
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.FileStorage;

public interface IFileStorage
{
  string QualifiedName { get; }

  Task<DateTime> GetLastWriteTimeAsync();

  Task<bool> ExistsAsync();

  string GetQualifiedName(string name);

  Task<bool> ExistsAsync(string fileName);

  Task<string> ReadAllTextAsync(string fileName);

  byte[] ReadAllBytes(string fileName);

  Task WriteAllTextAsync(string fileName, string contents);

  Task CreateAsync(string fileName, Stream inputStream);

  Task CopyFileToAsync(string fileName, Stream destination);

  Task DeleteFileAsync(string fileName);

  Task<List<string>> GetFileNamesAsync();

  Task<bool> DirectoryExistsAsync(string dirName);

  IFileStorage GetDirectory(string dirName);

  Task<IFileStorage> CreateDirectoryAsync(string dirName);

  Task DeleteDirectoryAsync(string dirName);

  Task<IEnumerable<FileStorageDirectoryInfo>> GetDirectoriesAsync();
}
