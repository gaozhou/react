using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.Linecast on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_Linecast_start_end_layerMask_queryTriggerInteraction : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public int layerMask;
        public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.Linecast(start, end, layerMask, queryTriggerInteraction))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.Linecast";
        public static string GetMenuPath() => "Physics/Condition/Linecast/(start, end, layerMask, queryTriggerInteraction)";
        public static string Signature() => " (start,end,layerMask,queryTriggerInteraction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}