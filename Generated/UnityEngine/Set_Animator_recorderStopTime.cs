using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Animator_recorderStopTime : LeafNode
    {
        public float value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.recorderStopTime = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animator>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.recorderStopTime";
        public static string GetMenuPath() => "Animator/Set/recorderStopTime";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
