using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Rigidbody2D.OverlapPoint on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Rigidbody2D_OverlapPoint_point : DecoratorNode
    {
        public UnityEngine.Vector2 point;


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.OverlapPoint(point)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody2D.OverlapPoint";
        public static string GetMenuPath() => "Rigidbody2D/If/OverlapPoint";
        public static string Signature() => " (point)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

    }
}