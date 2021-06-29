using Mirror;
using UnityEngine;

namespace QuickStart
{
    public class PlayerScript : NetworkBehaviour
    {
        public override void OnStartLocalPlayer()
        {
            transform.SetParent(Camera.main.transform);
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}