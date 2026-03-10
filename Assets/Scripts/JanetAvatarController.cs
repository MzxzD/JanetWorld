using UnityEngine;

namespace JanetWorld
{
    /// <summary>
    /// Controls the JANET avatar (Hatsune Miku-style model).
    /// Attach to the root of the Janet avatar GameObject.
    /// </summary>
    public class JanetAvatarController : MonoBehaviour
    {
        [SerializeField] private Transform avatarRoot;
        [SerializeField] private Animator animator;

        private void Awake()
        {
            if (avatarRoot == null)
                avatarRoot = transform;
        }

        /// <summary>
        /// Place avatar at world position for mixed reality placement.
        /// </summary>
        public void PlaceAt(Vector3 position, Quaternion rotation)
        {
            avatarRoot.SetPositionAndRotation(position, rotation);
        }

        /// <summary>
        /// Trigger idle or interaction animation.
        /// </summary>
        public void SetAnimationTrigger(string triggerName)
        {
            if (animator != null)
                animator.SetTrigger(triggerName);
        }
    }
}
