// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.IPostLoadMigration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary>Migration which performs some actions <see cref="M:Eco.Core.Serialization.Migrations.IPostLoadMigration.OnPostLoad" />. Call to <see cref="M:Eco.Core.Serialization.Migrations.IPostLoadMigration.OnPostLoad" /> adds to <see cref="F:Eco.Core.Serialization.Serializers.ClassSerializer.PostLoadMethods" /> if migration version higher than save version.</summary>
public interface IPostLoadMigration
{
  /// <summary>Callback for post-load migration actions.</summary>
  void OnPostLoad();
}
