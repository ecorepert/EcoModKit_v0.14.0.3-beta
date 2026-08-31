// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.CachedAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>Can be used to enable caching for property. Once evaluated the property won't be recalculated until receive PropertyChanged event. It uses Fody weaving for property body replacement generation.</summary>
/// <example><code><![CDATA[
/// public class Sample : INotifyPropertyChanged
/// {
///    public event PropertyChangedEventHadler PropertyChanaged;
/// 
///    [Cached] public DateTime CachedDateTime => Date.Now;
/// }
/// // will be transformed to
/// public class Sample : INotifyPropertyChanged
/// {
///    public event PropertyChangedEventHadler PropertyChanaged;
///    DateTime? <CachedDateTime>k_Cached;
/// 
///    public Sample()
///    {
///        PropertyChanged += Cache_OnPropertyChanged;
///    }
/// 
///    public void Cache_OnPropertyChanged(object source, PropertyChangedEventArgs args)
///    {
///        if (args.PropertyName == "CachedDateTime") this.<CachedDateTime>k_Cached = null;
///    }
/// 
///    [Cached] public DateTime CachedDateTime => this.<CachedDateTime>k_Cached ??= Date.Now;
/// }
/// ]]></code></example>
[AttributeUsage(AttributeTargets.Property)]
public class CachedAttribute : Attribute
{
}
