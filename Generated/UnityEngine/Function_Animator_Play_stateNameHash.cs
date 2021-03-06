using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animator_Play_stateNameHash : LeafNode
    {
        public int stateNameHash;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.Play(stateNameHash);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animator.Play";
        public static string GetMenuPath() => "Animator/Function/Play/(stateNameHash)";
        public static string Signature() => " (stateNameHash)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animator), typeof(Function_Animator_Play_stateNameHash));
    }
}
