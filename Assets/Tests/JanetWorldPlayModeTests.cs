using NUnit.Framework;
using UnityEngine;

namespace JanetWorld.Tests
{
    [TestFixture]
    public class JanetWorldPlayModeTests
    {
        [Test]
        public void PassthroughManager_Enable_Succeeds()
        {
            var go = new GameObject("PassthroughManager");
            var pm = go.AddComponent<PassthroughManager>();
            pm.SetPassthrough(true);
            Assert.IsTrue(pm.PassthroughEnabled);
        }

        [Test]
        public void JanetAvatar_Spawn_Exists()
        {
            var go = new GameObject("JanetAvatar");
            var ctrl = go.AddComponent<JanetAvatarController>();
            Assert.IsNotNull(ctrl);
            Assert.IsNotNull(ctrl.transform);
        }

        [Test]
        public void UserAvatar_Spawn_Exists()
        {
            var go = new GameObject("UserAvatar");
            var ctrl = go.AddComponent<UserAvatarController>();
            Assert.IsNotNull(ctrl);
            Assert.IsNotNull(ctrl.transform);
        }
    }
}
