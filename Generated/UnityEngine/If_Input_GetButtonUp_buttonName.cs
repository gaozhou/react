using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Input_GetButtonUp_buttonName : DecoratorNode
    {
        public string buttonName;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Input.GetButtonUp(buttonName)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetButtonUp";
        public static string GetMenuPath() => "Input/If/GetButtonUp";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class NotIf_Input_GetButtonUp_buttonName : DecoratorNode
    {
        public string buttonName;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Input.GetButtonUp(buttonName)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Input.GetButtonUp";
        public static string GetMenuPath() => "Input/If/GetButtonUp";
        public static string Signature() => " (buttonName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
