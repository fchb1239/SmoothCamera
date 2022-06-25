using System;

using UnityEngine;

using GorillaLocomotion;

namespace SmoothCamera.Behaviours
{
    class SmoothCamera : MonoBehaviour
    {
        private void Update()
        {
            transform.position = Player.Instance.headCollider.transform.position;
            transform.rotation = Quaternion.Slerp(transform.rotation, Player.Instance.headCollider.transform.rotation, 10 * Time.deltaTime);
        }
    }
}
