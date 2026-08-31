// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.DataInput
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Serializers;
using System.Collections.Generic;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

/// <summary>
/// <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.DataInput" /> defines input for migration which optionally may have own member inputs. During migration it may <see cref="M:Eco.Core.Serialization.Migrations.DataMigrations.DataInput.Read(Eco.Core.Serialization.Migrations.MigrationManager,System.IO.BinaryReader,System.IO.Stream,Eco.Core.Serialization.Serializers.ISerializer,System.Collections.Generic.Dictionary{Eco.Core.Serialization.Migrations.DataMigrations.IDataInput,Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput})" /> from <see cref="T:System.IO.BinaryReader" /> <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput" /> for itself and for all own members and update data mapping.
/// Using data inputs let you avoid full objects deserialization (and so delay it until actual deserialization stage keeping it binary compatible with migrations for newer versions).
/// I.e. you need to add a comment containing creator id to some entity. With data input it can be done like:
/// <code><![CDATA[
/// this.AddDataMigration(typeof(SomeType), dm => {
///     var creatorId = dm.Member("Creator").ReferenceId();
///     dm.AddMember<string>("Comment", new[] { creatorId }, inputs => $"Creator ID: {inputs[0].Value}");
/// });
/// ]]></code>
/// If you then have another migration for <c>SomeType</c> then it will work just fine with new serialized content containing Comment field.
/// 
/// Without data inputs you need to do it hacky way like
/// <code><![CDATA[
/// new ObjectInstanceMigration<SomeType, SomeType>(typeName, obj => {
///     SimpleFixups.Add(() => obj.Comment = $"Creator ID: {obj.Creator.Value}");
/// });
/// ]]></code>
/// It may look simpler, but it makes this migration incompatible with any further migration. I.e. if you then have new migration which uses Comment value for something else then you need to
/// modify old migration to do the update in SimpleFixup block in addition to new migration to make it compatible with different save versions.
/// </summary>
public class DataInput : IDataInput
{
  /// <summary>Input's member. Only valid for class/struct instance inputs.</summary>
  public MemberDataInput Member(string name);

  /// <summary>Input's reference id. Only valid for inputs representing serialized references.</summary>
  public DataInput ReferenceId();

  /// <summary>Reads input and nested inputs (for <see cref="F:Eco.Core.Serialization.Migrations.DataMigrations.DataInput.members" /> or <see cref="F:Eco.Core.Serialization.Migrations.DataMigrations.DataInput.referenceId" />) from <paramref name="reader" /> and puts to <paramref name="data" />.</summary>
  internal void Read(
    MigrationManager manager,
    BinaryReader reader,
    Stream instanceStream,
    ISerializer serializer,
    Dictionary<IDataInput, ReaderDataInput> data);
}
