using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets LineRenderer.sortingLayerID on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_sortingLayerID : LeafNode
    {
        public int value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sortingLayerID = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<LineRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.sortingLayerID";
        public static string GetMenuPath() => "LineRenderer/Set/sortingLayerID";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}