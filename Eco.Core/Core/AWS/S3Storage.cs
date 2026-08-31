// Decompiled with JetBrains decompiler
// Type: Eco.Core.AWS.S3Storage
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Amazon.S3;
using Eco.Core.FileStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.AWS;

public class S3Storage : IFileStorage
{
  public S3Storage(
  #nullable disable
  string accessKey, string secretKey, string region, string bucket, string key);

  public S3Storage(IAmazonS3 s3Client, string bucket, string key);

  public string QualifiedName { get; }

  public string GetQualifiedName(string name);

  public Task<bool> ExistsAsync();

  public Task<bool> ExistsAsync(string fileName);

  public Task<string> ReadAllTextAsync(string fileName);

  public byte[] ReadAllBytes(string fileName);

  public Task WriteAllTextAsync(string fileName, string contents);

  public Task CreateAsync(string fileName, Stream inputStream);

  public Task CopyFileToAsync(string fileName, Stream destination);

  public Task DeleteFileAsync(string fileName);

  public Task<bool> DirectoryExistsAsync(string dirName);

  public IFileStorage GetDirectory(string dirName);

  public Task<IFileStorage> CreateDirectoryAsync(string dirName);

  public Task DeleteDirectoryAsync(string dirName);

  public Task<IEnumerable<FileStorageDirectoryInfo>> GetDirectoriesAsync();

  public Task<List<string>> GetFileNamesAsync();

  public Task<DateTime> GetLastWriteTimeAsync();
}
