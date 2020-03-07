using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Uniteve {

    public class NetworkConnectionManager : MonoBehaviourPunCallbacks
    {
        // Start is called before the first frame update
        void Start()
        {
            PhotonNetwork.OfflineMode = false;
            PhotonNetwork.NickName = "Player "+Random.value;
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.GameVersion = "v1";

            PhotonNetwork.ConnectUsingSettings();

            
        }

        public override void OnConnectedToMaster() {
            PhotonNetwork.CreateRoom("Test Room!");
        }

        public override void OnJoinedRoom()
        {
            base.OnJoinedRoom();
            Debug.Log("Master: " + PhotonNetwork.IsMasterClient);
        }
    }
}
