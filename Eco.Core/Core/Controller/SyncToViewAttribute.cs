// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.SyncToViewAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Core.Controller;

/// <summary> SyncToView denotes a property or method result as a value that exists in the view on the client.
/// This is used on classes inheriting from IController, and will individually sync the tagged properties to the client.
/// Important Notes:
/// - If the properties never change apart from the parent, you can leave the class not derived from IController, and it will sync
/// all [Serialized] properties. If none are tagged Serializsed, it will sync all of them.  The class will need to defined in shared
/// code in this case, as only classes deriving IController get autogenned.
/// - Structs will also sync this way, syncing everything inside.</summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class SyncToViewAttribute : Attribute
{
  public readonly bool ViewIsReadOnly;
  public readonly string? PropertyName;
  public SyncFlags Flags;
  public Type? ViewType;

  public SyncToViewAttribute(SyncFlags flag);

  public SyncToViewAttribute(string? propertyName = null, bool viewIsReadOnly = true);
}
