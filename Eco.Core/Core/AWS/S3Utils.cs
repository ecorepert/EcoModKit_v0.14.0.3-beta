// Decompiled with JetBrains decompiler
// Type: Eco.Core.AWS.S3Utils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System.IO;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.AWS;

public static class S3Utils
{
  public static Task<PutObjectResponse> CreateFileFromStreamAsync(
    this IAmazonS3 s3,
    string bucket,
    string key,
    Stream inputStream,
    bool leaveOpen = false);

  public static Task<PutObjectResponse> CreateFileFromTextAsync(
    this IAmazonS3 s3,
    string bucket,
    string key,
    string text);

  public static string GetDirectory(this AmazonS3Uri uri);

  public static string GetName(this AmazonS3Uri uri);
}
