// Decompiled with JetBrains decompiler
// Type: Eco.Stats.LiteDbEnumMapper
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

#nullable enable
namespace Eco.Stats;

/// <summary>
/// This class responsible for mapping between code enums which uses by IStat and mapped database values.
/// It should be created with <see cref="T:Eco.Stats.LiteDbService" /> and then initialized with call to <see cref="M:Eco.Stats.LiteDbEnumMapper.Initialize" />.
/// When initialized it will automatically convert all enum values to integers when serializing to DB.
/// By default all enum values serialized as strings. Using integers instead helps to save lot of space.
/// Using enums meta table required to keep mapping in sync and also may be used to resolve mapped enum value to string with DB only data.
/// </summary>
public class LiteDbEnumMapper
{
  public LiteDbEnumMapper(LiteDbService liteDbService);

  /// <summary>Initializes <see cref="T:Eco.Stats.LiteDbEnumMapper" />. It syncs all stat's enums with database, builds mapping between enum value and mapped value (stored in db) and then registers custom enum members resolver.</summary>
  public void Initialize();

  private class EnumMeta
  {
    public string StatType { get; set; }

    public string Name { get; set; }

    public int MappedValue { get; set; }
  }
}
