using UnityEngine;
using System.Collections;
//using ExitGames.Client.Photon.LoadBalancing;

public class NetworkManager : MonoBehaviour {

    const string VERSION = "v0.0.1";
    public string roomName = "";
    public string prefabName = "";
    public Transform SpawnPoint;
    int group = 0;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(VERSION);
    }

    void OnJoinedLobby()
    {
        RoomOptions roomOption = new RoomOptions() { isVisible = false, maxPlayers = 3 }; //2 players in the same room 
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOption, TypedLobby.Default);
        Debug.Log("in OnJoinedLobby\nconnection status: " + PhotonNetwork.connected);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(prefabName, SpawnPoint.position, SpawnPoint.rotation, group);
        Debug.Log("prefab Name:" +prefabName);
    }

    //private LoadBalancingClient client;

    //// this is called when the client loaded and is ready to start
    //void Start()
    //{
    //    client = new LoadBalancingClient();
    //    client.AppId = "<your appid>";  // edit this!

    //    // "eu" is the European region's token
    //    bool connectInProcess = client.ConnectToRegionMaster("eu");  // can return false for errors
    //}

    //void Update()
    //{
    //    client.Service();
    //}

    //void OnApplicationQuit()
    //{
    //    client.Disconnect();
    //}
}
