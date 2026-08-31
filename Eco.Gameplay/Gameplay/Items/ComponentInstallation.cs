// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ComponentInstallation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Describes a single component to install on a host WorldObject. Construct via <see cref="M:Eco.Gameplay.Items.ComponentInstallation.For``1(System.String,System.Action{``0},System.Func{``0,System.Boolean},System.Boolean)" /> for type-safe configurators.</summary>
public sealed class ComponentInstallation
{
  public Type ComponentType { get; }

  public string Name { get; }

  public Action<WorldObjectComponent> Configure { get; }

  public Func<WorldObjectComponent, bool> CanUninstall { get; }

  public bool ProxyInteractions { get; }

  public static ComponentInstallation For<T>(
    string name = null,
    Action<T> configure = null,
    Func<T, bool> canUninstall = null,
    bool proxyInteractions = true)
    where T : WorldObjectComponent;
}
