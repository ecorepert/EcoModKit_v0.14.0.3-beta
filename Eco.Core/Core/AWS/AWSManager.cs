// Decompiled with JetBrains decompiler
// Type: Eco.Core.AWS.AWSManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Amazon.S3;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Core.AWS;

public class AWSManager : AutoSingleton<AWSManager>
{
  public IAmazonS3 CreateS3Client(string region = null);
}
