using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Target.CanSeeTarget on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Target_CanSeeTarget_range : LeafNode
    {
        public float range;


        DifferentMethods.React.Components.Target Component;

        protected override NodeState Execute() {
            if(Component.CanSeeTarget(range)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = Reactor.GetComponent<DifferentMethods.React.Components.Target>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Target.CanSeeTarget";
        public static string GetMenuPath() => "Target/Condition/CanSeeTarget";
        public static string Signature() => " (range)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Target);
    }
}