// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Serializers;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

public class ReaderDataInput : IDataInput
{
  public BinaryReader Reader { get; }

  public long Start { get; }

  public long End { get; }

  public ISerializer Serializer { get; }

  public string SchemaType { get; }

  public ReaderDataInput(BinaryReader reader, string schemaType, ISerializer serializer);

  public ReaderDataInput(
    BinaryReader reader,
    long start,
    long end,
    string schemaType,
    ISerializer serializer);

  public object Value { get; }

  /// <summary>Returns count of elements for Data Input value. For string it will be length of string, for enumerable or array number of elements in collection.
  /// If instance is <c>null</c> then return has null value. This way it let to get elements count without objects allocation and instantiation.
  /// </summary>
  /// <exception cref="T:System.NotSupportedException">When doesn't know how to get length for <see cref="P:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput.Serializer" />.</exception>
  public int? Count { get; }

  /// <summary> Represents Data Input value as string. Currently only implemented for enums and strings. </summary>
  public string StringValue { get; }

  public void CopyTo(Stream outputStream);

  public void ResetPosition();
}
