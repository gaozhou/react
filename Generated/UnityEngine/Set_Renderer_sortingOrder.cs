using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Renderer_sortingOrder : LeafNode
    {
        public int value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sortingOrder = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.sortingOrder";
        public static string GetMenuPath() => "Renderer/Set/sortingOrder";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
