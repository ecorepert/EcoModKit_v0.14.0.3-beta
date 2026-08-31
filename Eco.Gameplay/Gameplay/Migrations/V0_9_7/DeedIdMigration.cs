// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_7.DeedIdMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Migrations.Attributes;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_7;

[Migration(SinceVersion = 9.07)]
public class DeedIdMigration : AggregateMigration, IPostLoadMigration
{
  public void OnPostLoad();
}
