// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.Internal.GenericTypeSubscriptions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.PropertyHandling.Internal;

/// <summary>Internal class used by <see cref="T:Eco.Core.PropertyHandling.PropertyChanges" /> for global subscriptions (per-property and all-properties) for generic types. Has reference to generic type definition subscriptions.</summary>
internal class GenericTypeSubscriptions : TypeSubscriptions
{
  public GenericTypeSubscriptions(
    TypeSubscriptions genericTypeDefinitionSubscriptions);

  public override void Invoke(object sender, MemberChangedBeforeAfterEventArgs args);
}
