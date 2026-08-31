// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.DataMigrationExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

public static class DataMigrationExtensions
{
  public static void UpdateMember<T>(
    this DataMigration @this,
    string memberName,
    Func<T, T> updateMember);

  public static void UpdateMember<TSrc, TDst>(
    this DataMigration @this,
    string memberName,
    Func<TSrc, TDst> updateMember);

  public static void UpdateMember<T>(
    this DataMigration @this,
    string memberName,
    string[] dependencies,
    Func<T, object[], T> updateMember);

  public static void AddMember<TDst>(
    this DataMigration @this,
    string memberName,
    Func<TDst> addMember);

  public static void AddMember<TDst>(
    this DataMigration @this,
    string memberName,
    string[] dependencies,
    Func<object[], TDst> addMember);

  public static void AddMember(this DataMigration @this, string memberName, IDataInput value);

  public static void ReplaceMember<TDst>(
    this DataMigration @this,
    string memberName,
    Func<TDst> addMember);

  public static void ReplaceMember(this DataMigration @this, string memberName, IDataInput value);

  public static void MigrateMember(
    this DataMigration @this,
    string memberName,
    Action<DataMigration> buildDataMigration,
    bool skipIfMissing = false);

  public static void MigrateArrayMemberEntries(
    this DataMigration @this,
    string memberName,
    string elementType,
    IMigration elementMigration,
    bool skipIfMissing = false);

  public static void MigrateArrayMemberEntries(
    this DataMigration @this,
    string memberName,
    string elementType,
    string targetElementType,
    IMigration elementMigration,
    bool skipIfMissing = false);

  public static void MigrateEnumerableMemberEntries(
    this DataMigration @this,
    string memberName,
    string elementType,
    string targetElementType,
    IMigration elementMigration,
    bool skipIfMissing = false);
}
