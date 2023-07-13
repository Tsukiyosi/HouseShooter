using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class MenuManager : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField createLobbyInput;
    [SerializeField] TMP_InputField joinLobbyInput;
    public void CreateLobby(){
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(createLobbyInput.text, roomOptions);
    }
    public void JoinLobby(){
        PhotonNetwork.JoinRoom(joinLobbyInput.text);
    }

    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("Game");
    }
}
