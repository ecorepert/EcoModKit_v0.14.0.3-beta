// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.DataStoreContentAccessorDelegate
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Serialization;

/// <summary> Delegate for <see cref="M:Eco.Core.Serialization.DataStore.ContentAccessor.ExecuteAsync(Eco.Core.Serialization.DataStore.ExclusiveAccess,Eco.Core.Serialization.DataStoreContentAccessorDelegate)" />. </summary>
public delegate void DataStoreContentAccessorDelegate(in DataStore.ContentAccessor contentAccessor);
