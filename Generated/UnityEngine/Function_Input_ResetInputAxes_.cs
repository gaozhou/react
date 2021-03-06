using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Input_ResetInputAxes_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Input.ResetInputAxes();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Input.ResetInputAxes";
        public static string GetMenuPath() => "Input/Function/ResetInputAxes";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
