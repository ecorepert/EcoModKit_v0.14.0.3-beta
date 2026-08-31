// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ViewTypeAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>Defines View Type which should be used on client side instead of that type. Should be used when server and client side have same BSON serialization format, but different classes on server side and on the client. That type won't be generated and should be manually created on the client.</summary>
[AttributeUsage(AttributeTargets.Class)]
public class ViewTypeAttribute : Attribute
{
  public string ViewType;

  public ViewTypeAttribute(string viewType);
}
