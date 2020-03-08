using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Uniteve
{
    public class Controller : MonoBehaviour
    {
        protected Player Player;
        protected NetworkConnectionManager NetworkConnectionManager;

        // Start is called before the first frame update
        void Start()
        {
            Player = GetComponent<Player>();
            NetworkConnectionManager = GetComponent<NetworkConnectionManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W)) {
                Debug.Log("increase vel");
                Player.Input.RunZ += 100;
            }
            if (Input.GetKeyDown(KeyCode.D)) {
                Player.Input.RunZ -= 100;
            }
            if (Input.GetKeyDown(KeyCode.J)) {
                NetworkConnectionManager.StartConnecting();
            }
        }
    }
}