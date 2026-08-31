// Decompiled with JetBrains decompiler
// Type: Eco.Shared.IoC.ServiceHolder`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.IoC;

public static class ServiceHolder<T>
{
  /// <summary>Service's current singleton instance.</summary>
  public static T Obj;

  /// <summary> Creates new instance of <typeparamref name="TImpl" /> and replaces <see cref="F:Eco.Shared.IoC.ServiceHolder`1.Obj" /> with new value.</summary>
  public static TImpl CreateAndReplace<TImpl>() where TImpl : T, new();

  /// <summary>Gets existing instance of service or if not set then creates new instance of <typeparamref name="TImpl" /> type and sets it.</summary>
  public static T GetOrCreate<TImpl>() where TImpl : T, new();

  /// <summary>Sets or replaces an existing instance of service with a new value.</summary>
  public static T SetOrReplace<TImpl>(TImpl instance) where TImpl : T;
}
