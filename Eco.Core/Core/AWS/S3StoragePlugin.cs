// Decompiled with JetBrains decompiler
// Type: Eco.Core.AWS.S3StoragePlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.FileStorage;
using Eco.Core.Plugins.Interfaces;

#nullable disable
namespace Eco.Core.AWS;

/// <summary><see cref="T:Eco.Core.Plugins.Interfaces.IFileStoragePlugin" /> implementation to allow Eco server access to an S3 bucket for backup retention on SLG services.</summary>
/// <seealso cref="T:Eco.Core.Plugins.Interfaces.IFileStoragePlugin" />
public class S3StoragePlugin : IFileStoragePlugin, IServerPlugin
{
  public bool SupportsStorageType(string storageType);

  public IFileStorage GetStorage();

  public string GetCategory();

  public string GetStatus();

  public override string ToString();
}
