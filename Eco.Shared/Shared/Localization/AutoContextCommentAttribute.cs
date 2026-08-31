// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.AutoContextCommentAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary>
/// Add context comment to Classes, Fields, Properties and Enums auto-localized via <see cref="T:Eco.Shared.Networking.EcoAttribute" /> or <see cref="T:Eco.Shared.Localization.LocalizedAttribute" />
/// e.g.:
/// [Localized] class Player
/// {
///     [AutoContextComment("Player Configuration")]
///     public Setting  Config { get; set; }
/// }
/// 
/// will extract "Config" loc string with context 'Player Configuration'
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field)]
public class AutoContextCommentAttribute : Attribute
{
  public string Comment { get; protected set; }

  public AutoContextCommentAttribute(string comment);
}
