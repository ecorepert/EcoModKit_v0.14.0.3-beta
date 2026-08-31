// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.INotifyRecursiveChanged
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Systems;

/// <summary>An interface that will be notified whenever a property that have a property scanner on it is changed using a client side view interface (Ie. an AutoGenSelector).</summary>
public interface INotifyRecursiveChanged
{
  void OnRecursiveChange(PropertyInfo prop, object objParent);
}
