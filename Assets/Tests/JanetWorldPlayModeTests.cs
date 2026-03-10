using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using System.Collections;

namespace JanetWorld.Tests
{
    [TestFixture]
    public class JanetWorldPlayModeTests
    {
        [UnityTest]
        public IEnumerator PassthroughManager_Enable_Succeeds()
        {
            var go = new GameObject("PassthroughManager");
            var pm = go.AddComponent<PassthroughManager>();
            pm.SetPassthrough(true);
            Assert.IsTrue(pm.PassthroughEnabled);
            yield return null;
        }

        [UnityTest]
        public IEnumerator JanetAvatar_Spawn_Exists()
        {
            var go = new GameObject("JanetAvatar");
            var ctrl = go.AddComponent<JanetAvatarController>();
            Assert.IsNotNull(ctrl);
            Assert.IsNotNull(ctrl.transform);
            yield return null;
        }

        [UnityTest]
        public IEnumerator UserAvatar_Spawn_Exists()
        {
            var go = new GameObject("UserAvatar");
            var ctrl = go.AddComponent<UserAvatarController>();
            Assert.IsNotNull(ctrl);
            Assert.IsNotNull(ctrl.transform);
            yield return null;
        }
    }
}
