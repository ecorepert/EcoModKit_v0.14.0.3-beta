// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.DataBlob
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.IO;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary> Contains named raw data for <see cref="T:Eco.Core.Serialization.DataStore" />. </summary>
public class DataBlob
{
  /// <summary> Entry name. </summary>
  public string Name { get; set; }

  /// <summary> Raw data. </summary>
  public Stream Data { get; set; }

  public DataBlob(Stream data, string name);
}
