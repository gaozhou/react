using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_LineRenderer_allowOcclusionWhenDynamic : LeafNode
    {
        public bool value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.allowOcclusionWhenDynamic = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.allowOcclusionWhenDynamic";
        public static string GetMenuPath() => "LineRenderer/Set/allowOcclusionWhenDynamic";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
