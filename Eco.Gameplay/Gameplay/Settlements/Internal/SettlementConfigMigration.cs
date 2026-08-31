// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.SettlementConfigMigration
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Newtonsoft.Json.Linq;

#nullable disable
namespace Eco.Gameplay.Settlements.Internal;

public static class SettlementConfigMigration
{
  /// <summary>Brings a stored config up to the current version. Edits the JObject in place; it's populated onto the config right after.</summary>
  public static void Migrate(SettlementConfig config, JObject json);
}
