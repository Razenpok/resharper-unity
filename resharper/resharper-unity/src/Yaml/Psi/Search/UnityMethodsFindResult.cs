using JetBrains.ReSharper.Plugins.Unity.Yaml.Psi.DeferredCaches.AssetHierarchy.Elements;
using JetBrains.ReSharper.Plugins.Unity.Yaml.Psi.DeferredCaches.AssetHierarchy.References;
using JetBrains.ReSharper.Plugins.Unity.Yaml.Psi.DeferredCaches.UnityEvents;
using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.Unity.Yaml.Psi.Search
{
    public class UnityMethodsFindResult : UnityAssetFindResult
    {
        public AssetMethodData AssetMethodData { get; }
        public bool IsPrefabModification { get; }

        public UnityMethodsFindResult(IPsiSourceFile sourceFile, IDeclaredElement declaredElement, AssetMethodData assetMethodData,
            LocalReference attachedElementLocation, bool isPrefabModification)
            : base(sourceFile, declaredElement, attachedElementLocation)
        {
            AssetMethodData = assetMethodData;
            IsPrefabModification = isPrefabModification;
        }

        protected bool Equals(UnityMethodsFindResult other)
        {
            return base.Equals(other) && AssetMethodData.Equals(other.AssetMethodData);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((UnityMethodsFindResult) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ AssetMethodData.GetHashCode();
            }
        }
    }
}