// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RPCMethod
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Reflection;

#nullable enable
namespace Eco.Shared.Networking;

/// <summary><see cref="T:Eco.Shared.Networking.RPCMethod" /> contains all meta information about RPC method like name, flags, required arguments, required access etc.</summary>
public class RPCMethod
{
  public RPCMethodFlags Flags { get; }

  public int Id { get; }

  public string Name { get; }

  public bool IsExtension { get; }

  public bool CanAutoPrependClient { get; }

  public bool CanAutoPrependObserver { get; }

  public bool CanAutoPrependConvertedObserver { get; }

  public bool CanAutoPrepend { get; }

  public bool IsCustomSetter { get; }

  public MethodInfo MethodInfo { get; }

  public PropertyInfo? PropertyInfo { get; }

  public System.Func<object, object[], object?> Func { get; }

  public object? FallbackValue { get; }

  public ParameterInfo[] Parameters { get; }

  public IRPCAttribute? RelevantAttribute { get; }

  public MemberInfo MemberInfo { get; }

  public string MethodKey { get; }

  public RPCMethod(MethodInfo mi);

  public RPCMethod(PropertyInfo pi);
}
