using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Input_backButtonLeavesApp_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.backButtonLeavesApp)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.backButtonLeavesApp";
        public static string GetMenuPath() => "Input/Condition/backButtonLeavesApp";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class Not_Condition_Input_backButtonLeavesApp_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.backButtonLeavesApp)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.backButtonLeavesApp";
        public static string GetMenuPath() => "Input/Condition/backButtonLeavesApp";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
