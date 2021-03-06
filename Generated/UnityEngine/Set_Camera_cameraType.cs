using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Camera_cameraType : LeafNode
    {
        public UnityEngine.CameraType value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.cameraType = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.cameraType";
        public static string GetMenuPath() => "Camera/Set/cameraType";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
