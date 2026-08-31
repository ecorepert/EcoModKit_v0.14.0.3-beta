// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.CurrentSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization;

internal class CurrentSerializer : IVersionSerializer
{
  public string Schema { get; }

  public void InitDeserializer(
    string schema,
    double schemaVersion,
    MigrationManager migrationManager);

  public void SerializeTo(Stream stream, object obj);

  public void SerializeTo<T>(Stream stream, T obj);

  public object Deserialize(Stream stream);

  public T Deserialize<T>(Stream stream);

  public void FinishDeserialization();
}
