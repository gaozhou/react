using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of SpriteRenderer.enabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_SpriteRenderer_enabled_ : LeafNode
    {


        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK SpriteRenderer.enabled";
        public static string GetMenuPath() => "SpriteRenderer/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);
    }
}