// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.StandardSerializers
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Serializers;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary>
/// Holder for standard serializers which used by different serialization systems (i.e. <see cref="T:Eco.Core.Serialization.Migrations.SchemaUtils" /> and <see cref="T:Eco.Core.Serialization.SimpleSerializer" />).
/// It may not be part of SimpleSerializer, because when accessed it will force static constructor initialization logic which will cause different problems in runtime (i.e. not all assemblies may be loaded and assembly scan won't find all serializable types).
/// </summary>
internal class StandardSerializers
{
  /// <summary>Creates array of standard serializers to be used by <see cref="T:Eco.Core.Serialization.SimpleSerializer" /> or <see cref="T:Eco.Core.Serialization.Migrations.SchemaUtils" />. Can't use shared instance, because serializers not stateless and has ID assigned by <see cref="T:Eco.Core.Serialization.SimpleSerializer" />.</summary>
  internal static ISerializer[] CreateStandardSerializers();
}
