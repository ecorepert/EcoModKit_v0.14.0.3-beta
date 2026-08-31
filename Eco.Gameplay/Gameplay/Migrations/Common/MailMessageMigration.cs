// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.Common.MailMessageMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;

#nullable enable
namespace Eco.Gameplay.Migrations.Common;

/// <summary>Base migration for Mail Messages.&gt;</summary>
public abstract class MailMessageMigration : DataMigration
{
  /// <summary>Checks if mail message should be migrated.</summary>
  protected virtual bool ShouldMigrateMessage(string? commonId, string text);

  /// <summary>Migrates CommonId for mail message.</summary>
  protected virtual string? MigrateCommonId(string? commonId, string text);

  /// <summary>Migrates Text for mail message.</summary>
  protected virtual string MigrateText(string? commonId, string text);
}
