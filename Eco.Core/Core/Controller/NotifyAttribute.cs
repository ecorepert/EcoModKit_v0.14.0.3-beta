// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.NotifyAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>Attribute which may be used to mark a property/method as controller property which may be used in Subscribe/Changed methods. By default only properties with <see cref="N:Eco" />, <see cref="T:Eco.Core.Controller.SyncToViewAttribute" /> and <see cref="T:Eco.Core.Controller.ClientInterfacePropertyAttribute" /> notified, but if you still need to subscribe to property without syncing to client then the attribute may be used.</summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class NotifyAttribute : Attribute
{
}
