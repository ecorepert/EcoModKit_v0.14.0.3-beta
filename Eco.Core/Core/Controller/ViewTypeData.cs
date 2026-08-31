// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ViewTypeData
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Core.Controller;

[Serialized]
[LocDisplayName("ViewTypeData")]
public class ViewTypeData : IStorage, ISerializable
{
  [Serialized]
  public ThreadSafeDictionary<string, int> TypeNameToId;

  public IPersistent? StorageHandle { get; set; }
}
