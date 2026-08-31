// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Icons.IconUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Icons;

/// <summary>Various shared things related to icons</summary>
public static class IconUtils
{
  public static LocString XPPerDay(float val);

  [HasEnumIcons("Symbolic Icons")]
  public enum SymbolicIcons
  {
    XP,
    Checkmark,
    RedX,
    Error,
    Culture,
    CurrencySymbol,
    EcoCredit,
    Nutrition,
    NoCraving,
    QuestionMark,
    EmptyIcon,
    Globe,
    InfluenceRadius,
    Reputation,
    House,
    DinnerParty,
  }

  [HasEnumIcons("Miscellaneous Icons")]
  public enum MiscIcons
  {
    PaintBucketPaint,
    Admin,
    Build,
    Transport,
    Invalid,
    Title,
    Welcome,
    General,
    Notifications,
    Government,
    Elections,
    Crafting,
    Meteor,
    Trades,
    YourTrades,
    Tax,
    Property,
    Skills,
    Logins,
    Auth,
    Objectives,
    Contracts,
    YourContracts,
    YourTransfers,
    ServerLog,
    Finance,
    Wages,
    Transfers,
    Demographics,
    DemographicContext,
    Education,
    Achievement,
    Settlement0,
    Settlement1,
    Settlement2,
    Settlements,
    BuildContract,
    ConstitutionalArticle,
    CashRegister,
    CivicObject,
    FlatTree,
    LogoPlanet,
    NoSkillLabor,
  }
}
