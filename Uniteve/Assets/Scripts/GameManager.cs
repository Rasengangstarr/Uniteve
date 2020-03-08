using UnityEngine;
using System.Collections;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

namespace Uniteve
{
    public class GameManager : MonoBehaviourPunCallbacks
    {
        [Header("UC Game Manager")]

        public Player PlayerPrefab;

        [HideInInspector]
        public Player LocalPlayer;

        private void Awake()
        {
            if (!PhotonNetwork.IsConnected)
            {
                Debug.Log("not connected!");
                return;
            }
        }

        // Use this for initialization
        void Start()
        {
            Debug.Log("Refreshing instance!");
            Player.RefreshInstance(ref LocalPlayer, PlayerPrefab);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
        {
            Player.RefreshInstance(ref LocalPlayer, PlayerPrefab);
        }
    }
}