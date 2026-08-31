// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.NotificationCategory
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.Services;

[Serialized]
[Localized(true, false, "", false)]
public enum NotificationCategory
{
  Welcome,
  Notifications,
  Government,
  [ExcludeFromChat] Elections,
  Crafting,
  [ExcludeFromChat] Meteor,
  [ExcludeFromChat] Trades,
  YourTrades,
  [ExcludeFromChat] Tax,
  [ExcludeFromChat] Property,
  [ExcludeFromChat] Skills,
  [ExcludeFromChat] Logins,
  Auth,
  [ExcludeFromChat] Reputation,
  [ExcludeFromChat] Objectives,
  [ExcludeFromChat] Contracts,
  YourContracts,
  YourTransfers,
  ServerLog,
  [ExcludeFromChat] Finance,
  Wages,
  [ExcludeFromChat] Transfers,
  [ExcludeFromChat] Demographics,
  [ExcludeFromChat] Settlements,
  [ExcludeFromChat] Education,
  [ExcludeFromChat] Achievement,
  [ExcludeFromChat] Admin,
}
