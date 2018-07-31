using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets SpriteRenderer.realtimeLightmapIndex on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_SpriteRenderer_realtimeLightmapIndex : LeafNode
    {
        public int value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.realtimeLightmapIndex = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<SpriteRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.realtimeLightmapIndex";
        public static string GetMenuPath() => "SpriteRenderer/Set/realtimeLightmapIndex";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}