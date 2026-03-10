using UnityEngine;

#if UNITY_ANDROID && !UNITY_EDITOR
using UnityEngine.XR.OpenXR.Features.MetaQuestSupport;
#endif

namespace JanetWorld
{
    /// <summary>
    /// Manages Passthrough layer for Mixed Reality.
    /// Use Meta Building Blocks for setup; this script provides runtime control.
    /// </summary>
    public class PassthroughManager : MonoBehaviour
    {
        [SerializeField] private bool passthroughEnabled = true;

        public bool PassthroughEnabled => passthroughEnabled;

        private void Start()
        {
            ApplyPassthrough();
        }

        /// <summary>
        /// Toggle Passthrough on/off.
        /// </summary>
        public void SetPassthrough(bool enabled)
        {
            passthroughEnabled = enabled;
            ApplyPassthrough();
        }

        private void ApplyPassthrough()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            // Meta XR Passthrough layer control
            // In production, use Meta's OVRManager or Passthrough API
            // OVRManager.instance.isInsightPassthroughEnabled = passthroughEnabled;
#endif
            // Placeholder: actual implementation uses Meta XR SDK Passthrough API
        }
    }
}
