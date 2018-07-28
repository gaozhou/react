using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Target.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Target_enabled : LeafNode
    {
        public bool value;

        Target Component;

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<Target>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Target.enabled";
        public static string GetMenuPath() => "Target/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Target);
    }
}