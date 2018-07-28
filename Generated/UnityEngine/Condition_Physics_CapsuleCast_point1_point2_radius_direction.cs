using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics.CapsuleCast on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics_CapsuleCast_point1_point2_radius_direction : LeafNode
    {
        public UnityEngine.Vector3 point1;
        public UnityEngine.Vector3 point2;
        public float radius;
        public UnityEngine.Vector3 direction;

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics.CapsuleCast(point1, point2, radius, direction))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics.CapsuleCast";
        public static string GetMenuPath() => "Physics/Condition/CapsuleCast/(point1, point2, radius, direction)";
        public static string Signature() => " (point1,point2,radius,direction)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}