using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Application_Unload_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Application.Unload();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Application.Unload";
        public static string GetMenuPath() => "Application/Function/Unload";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
