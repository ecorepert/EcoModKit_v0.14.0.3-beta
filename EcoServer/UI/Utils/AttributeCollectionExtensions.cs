// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.Utils.AttributeCollectionExtensions
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Server.UI.Utils;

public static class AttributeCollectionExtensions
{
  public static T GetAttributeOfType<T>(this AttributeCollection attributeCollection) where T : Attribute;

  public static T GetAttributeOfType<T>(this Attribute[] attributeArray) where T : Attribute;
}
