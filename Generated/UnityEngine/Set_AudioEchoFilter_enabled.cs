using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets AudioEchoFilter.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_AudioEchoFilter_enabled : LeafNode
    {
        public bool value;

        protected AudioEchoFilter Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<AudioEchoFilter>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET AudioEchoFilter.enabled";
        public static string GetMenuPath() => "AudioEchoFilter/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(AudioEchoFilter);
    }
}