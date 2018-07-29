using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Rigidbody2D.useFullKinematicContacts on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Rigidbody2D_useFullKinematicContacts_ : LeafNode
    {


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.useFullKinematicContacts) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Rigidbody2D.useFullKinematicContacts";
        public static string GetMenuPath() => "Rigidbody2D/Condition/useFullKinematicContacts";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }
}