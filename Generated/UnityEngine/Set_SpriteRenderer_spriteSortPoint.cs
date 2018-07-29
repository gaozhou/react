using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets SpriteRenderer.spriteSortPoint on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_spriteSortPoint : LeafNode
    {
        public UnityEngine.SpriteSortPoint value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.spriteSortPoint = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<SpriteRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.spriteSortPoint";
        public static string GetMenuPath() => "SpriteRenderer/Set/spriteSortPoint";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
