// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.MayHaveComponentAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary> Declare this objects that may or may not have a given component. This is needed because any component that is not [Required] or [MayRequire] will be removed on server load, as a way of migrating away old component. </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class MayHaveComponentAttribute : Attribute
{
  public string ComponentName;

  public Type ComponentType { get; }

  public MayHaveComponentAttribute(Type type, string name = null);
}
