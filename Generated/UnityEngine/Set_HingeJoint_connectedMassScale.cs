using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets HingeJoint.connectedMassScale on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_HingeJoint_connectedMassScale : LeafNode
    {
        public float value;

        protected HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            Component.connectedMassScale = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<HingeJoint>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET HingeJoint.connectedMassScale";
        public static string GetMenuPath() => "HingeJoint/Set/connectedMassScale";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(HingeJoint);
    }
}
