using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Animation_CrossFade_animation_fadeLength_mode : LeafNode
    {
        public string animation;
        public float fadeLength;
        public UnityEngine.PlayMode mode;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.CrossFade(animation, fadeLength, mode);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.CrossFade";
        public static string GetMenuPath() => "Animation/Function/CrossFade/(animation, fadeLength, mode)";
        public static string Signature() => " (animation,fadeLength,mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_CrossFade_animation_fadeLength_mode));
    }
}
