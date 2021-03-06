using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Rigidbody2D_IsTouching_collider : DecoratorNode
    {
        public UnityEngine.Collider2D collider;

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsTouching(collider)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody2D.IsTouching";
        public static string GetMenuPath() => "Rigidbody2D/If/IsTouching/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }

    
    [System.Serializable]
    public class Not_If_Rigidbody2D_IsTouching_collider : DecoratorNode
    {
        public UnityEngine.Collider2D collider;

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.IsTouching(collider)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Rigidbody2D.IsTouching";
        public static string GetMenuPath() => "Rigidbody2D/If/IsTouching/(collider)";
        public static string Signature() => " (collider)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }
}
