// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.ContextCommentAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary>
/// For Classes, Fields, Properties, Methods and Enums to localize other attribute parameters
/// e.g.:
/// [Eco, LocDescription("Some description"), ContextComment(typeof(LocDescriptionAttribute), "Some description context")]
/// public class CivicAction_AddElement
/// {
///     [AutoContextComment("Player Configuration")]
///     public Setting  Config { get; set; }
/// }
/// 
/// will extract "Some description" loc string with context 'Some description context'
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public class ContextCommentAttribute : Attribute
{
  public Type AttributeType { get; protected set; }

  public string[] Comments { get; protected set; }

  public ContextCommentAttribute(Type attributeType, params string[] comments);
}
