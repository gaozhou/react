using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of LineRenderer.generateLightingData on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_LineRenderer_generateLightingData_ : DecoratorNode
    {


        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.generateLightingData) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF LineRenderer.generateLightingData";
        public static string GetMenuPath() => "LineRenderer/If/generateLightingData";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);

    }
}
