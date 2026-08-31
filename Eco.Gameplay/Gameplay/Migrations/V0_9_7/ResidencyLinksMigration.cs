// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_7.ResidencyLinksMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Gameplay.Migrations.Common;

#nullable enable
namespace Eco.Gameplay.Migrations.V0_9_7;

/// <summary>Removes user id from residency links.</summary>
[Migration(SinceVersion = 9.07)]
public class ResidencyLinksMigration : MailMessageMigration
{
  protected override bool ShouldMigrateMessage(string? commonId, string text);

  /// <summary>Removes user id from residency links.</summary>
  protected override string MigrateText(string? commonId, string text);
}
