using UnityEngine;

namespace JanetWorld
{
    /// <summary>
    /// Controls the USER avatar (Kazuma from KonoSuba).
    /// Follows XR rig / camera for first-person or tracks controller for placement.
    /// </summary>
    public class UserAvatarController : MonoBehaviour
    {
        [SerializeField] private Transform avatarRoot;
        [SerializeField] private Transform followTarget; // XR Camera Rig or controller

        private void Awake()
        {
            if (avatarRoot == null)
                avatarRoot = transform;
        }

        private void LateUpdate()
        {
            if (followTarget != null)
            {
                avatarRoot.SetPositionAndRotation(followTarget.position, followTarget.rotation);
            }
        }

        /// <summary>
        /// Set the transform to follow (e.g. XR Origin/Camera).
        /// </summary>
        public void SetFollowTarget(Transform target)
        {
            followTarget = target;
        }
    }
}
