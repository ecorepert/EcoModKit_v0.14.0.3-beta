// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_0.DataStore.EconomyManagerDataStoreMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using System;

#nullable enable
namespace Eco.Gameplay.Migrations.V0_9_0.DataStore;

public class EconomyManagerDataStoreMigration : IDataStoreMigration
{
  public void Migrate(
    #nullable disable
    Eco.Core.Serialization.DataStore.ExclusiveAccess dataStore,
    Type type,
    Action<object, string> onLoad);
}
