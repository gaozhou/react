using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Animator_keepAnimatorControllerStateOnDisable : LeafNode
    {
        public bool value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.keepAnimatorControllerStateOnDisable = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animator>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.keepAnimatorControllerStateOnDisable";
        public static string GetMenuPath() => "Animator/Set/keepAnimatorControllerStateOnDisable";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
