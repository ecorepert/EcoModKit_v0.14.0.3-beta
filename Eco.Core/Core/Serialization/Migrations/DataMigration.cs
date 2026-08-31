// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations.DataMigrations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Data migration class performs data level modifications (change member type, migrate member, update member, rename member, delete member etc).</summary>
public class DataMigration : InstanceMigration
{
  /// <summary>Internal <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" /> constructor not compatible with any type. Intended to be used for nested migrations (like member migrations).</summary>
  internal DataMigration();

  public DataMigration(string compatibleType);

  public DataMigration(IEnumerable<string> compatibleTypes);

  public override void Initialize(MigrationManager migrationManager);

  public override void MigrateInstance(MigrationContext context);

  public MemberDataInput Member(string name);

  /// <summary>Adds pre-condition for data migration. If pre-condition fails then migration will not be applied.</summary>
  public void AddPrecondition<T>(string memberName, Predicate<T> predicate);

  /// <summary>Adds pre-condition for data migration. If pre-condition fails then migration will not be applied.</summary>
  public void AddPrecondition(IEnumerable<string> argMembers, Predicate<object[]> predicate);

  /// <summary>Adds pre-condition for data migration. If pre-condition fails then migration will not be applied.</summary>
  public void AddPrecondition(IDataInput[] inputs, Predicate<object[]> predicate);

  /// <summary>Updates member by converting old value to new value. Member schema type changes accordingly.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void UpdateMember<TSrc, TDst>(string memberName, Func<TSrc, TDst> updateMember);

  public void UpdateMember<TSrc, TDst>(
    string memberName,
    string[] dependencies,
    Func<TSrc, object[], TDst> updateMember);

  public void UpdateMember<TSrc, TDst>(
    string memberName,
    IDataInput[] dependencies,
    Func<TSrc, ReaderDataInput[], TDst> updateMember,
    Func<TDst>? whenMissing = null);

  /// <summary> Updates member using <see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.ReaderDataInput" /> as original value. It produces value of <typeparamref name="TDst" /> type. </summary>
  public void UpdateMemberFromDataInput<TDst>(
    string memberName,
    IDataInput[] dependencies,
    Func<ReaderDataInput, ReaderDataInput[], TDst> updateMember);

  public void UpdateMember(
    string memberName,
    IDataInput[] dependencies,
    Func<ReaderDataInput, ReaderDataInput[], ReaderDataInput> updateMember);

  public void AddMember<TDst>(
    string memberName,
    IDataInput[] dependencies,
    Func<ReaderDataInput[], TDst> addMember);

  public void AddMember(
    string memberName,
    IDataInput[] dependencies,
    Func<ReaderDataInput[], ReaderDataInput> addMember);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void ReplaceMember<TDst>(
    string memberName,
    IDataInput[] dependencies,
    Func<ReaderDataInput[], TDst> memberGenerator);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void ReplaceMember(
    string memberName,
    IDataInput[] dependencies,
    Func<ReaderDataInput[], ReaderDataInput> memberGenerator);

  public void RenameMember(string oldMemberName, string newMemberName, bool skipIfMissing = false);

  public void ChangeMemberSchemaType(string memberName, string newSchemaType, bool skipIfMissing = false);

  public void AddReferenceMember(
    string memberName,
    string memberSchemaType,
    IDataInput[] dependencies,
    Func<ReaderDataInput[], (string TypeName, int ID)> referenceGenerator);

  public void MigrateMember(string memberName, IMigration migration, bool skipIfMissing = false);

  /// <summary>Changes class schema type to <paramref name="newSchemaType" />. I.e. after all members converted you may decide to convert class itself to another type.</summary>
  public void ChangeSchemaType(string newSchemaType);
}
