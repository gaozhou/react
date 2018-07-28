using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Handheld.Vibrate on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Handheld_Vibrate_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Handheld.Vibrate();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Handheld.Vibrate";
        public static string GetMenuPath() => "Handheld/Function/Vibrate";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}