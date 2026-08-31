// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.Common.ItemRenameMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Migrations.Common;

/// <summary><see cref="T:Eco.Gameplay.Migrations.Common.ItemRenameMigration" /> simplifies renaming of <see cref="T:Eco.Gameplay.Items.Item" /> classes. It takes care about item objects (if existed) and existing work orders for that item.</summary>
public class ItemRenameMigration : MigrationCollection
{
  public ItemRenameMigration(string oldItemName, string newItemName);

  public ItemRenameMigration(Dictionary<string, string> renames);
}
