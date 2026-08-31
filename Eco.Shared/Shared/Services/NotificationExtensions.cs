// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.NotificationExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;

#nullable disable
namespace Eco.Shared.Services;

public static class NotificationExtensions
{
  public static string TagName(this NotificationCategory category);

  public static bool TryGetStyle(this NotificationStyle category, out Text.Styles textStyle);

  public static string FormatMessage(this NotificationStyle style, string text);
}
