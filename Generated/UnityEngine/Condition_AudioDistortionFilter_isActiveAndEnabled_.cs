using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of AudioDistortionFilter.isActiveAndEnabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_AudioDistortionFilter_isActiveAndEnabled_ : LeafNode
    {


        protected UnityEngine.AudioDistortionFilter Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.AudioDistortionFilter>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioDistortionFilter.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioDistortionFilter/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioDistortionFilter);
    }
}
