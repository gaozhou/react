using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_TrailRenderer_alignment : LeafNode
    {
        public UnityEngine.LineAlignment value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.alignment = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.alignment";
        public static string GetMenuPath() => "TrailRenderer/Set/alignment";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
