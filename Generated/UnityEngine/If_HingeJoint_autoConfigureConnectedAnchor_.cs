using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of HingeJoint.autoConfigureConnectedAnchor on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_HingeJoint_autoConfigureConnectedAnchor_ : DecoratorNode
    {


        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.autoConfigureConnectedAnchor) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF HingeJoint.autoConfigureConnectedAnchor";
        public static string GetMenuPath() => "HingeJoint/If/autoConfigureConnectedAnchor";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);

    }
}