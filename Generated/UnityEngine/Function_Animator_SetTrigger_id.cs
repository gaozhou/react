using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_SetTrigger_id : LeafNode
    {
        public int id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.SetTrigger(id);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.SetTrigger";
        public static string GetMenuPath() => "Animator/Function/SetTrigger/(id)";
        public static string Signature() => " (id)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_SetTrigger_id));
    }
}
