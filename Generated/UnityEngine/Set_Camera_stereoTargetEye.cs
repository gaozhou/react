using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Camera_stereoTargetEye : LeafNode
    {
        public UnityEngine.StereoTargetEyeMask value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.stereoTargetEye = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.stereoTargetEye";
        public static string GetMenuPath() => "Camera/Set/stereoTargetEye";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
