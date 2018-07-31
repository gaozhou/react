using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of HingeJoint.useLimits on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_HingeJoint_useLimits_ : DecoratorNode
    {


        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.useLimits) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF HingeJoint.useLimits";
        public static string GetMenuPath() => "HingeJoint/If/useLimits";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);

    }
}