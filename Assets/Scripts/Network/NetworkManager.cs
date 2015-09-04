using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
//using ExitGames.Client.Photon.LoadBalancing;

public class NetworkManager : MonoBehaviour {

    const string VERSION = "v0.0.1";
    public string roomName = "";
    public string prefabName = "";
    public Transform SpawnPoint1, SpawnPoint2;

    private List<Transform> SpawnPoints = new List<Transform>();
    private int i = 0;
    int group = 0;
    byte maxPlayer = 4;
    GameObject player;
    void Start()
    {
        if(!PhotonNetwork.connected)
            PhotonNetwork.ConnectUsingSettings(VERSION);
        SpawnPoints.Add(SpawnPoint1);
        SpawnPoints.Add(SpawnPoint2);
    }

    void OnJoinedLobby()
    {
        RoomOptions roomOption = new RoomOptions() { isVisible = false, maxPlayers = maxPlayer }; //2 players in the same room 
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOption, TypedLobby.Default);
        Debug.Log("in OnJoinedLobby\nconnection status: " + PhotonNetwork.connected);
    }

    void OnJoinedRoom()
    {
//        GameObject player =  PhotonNetwork.Instantiate(prefabName, SpawnPoints[i].position, SpawnPoints[i].rotation, group);
        player = PhotonNetwork.Instantiate(prefabName, SpawnPoint1.position, SpawnPoint1.rotation, group);
        player.tag = Globals.Tags.Player.ToString();
        player.transform.position = SpawnPoints[player.GetPhotonView().viewID/1000].position;
        player.SetActive(true);
        Debug.Log("prefab Name:" + prefabName + " number: " + player.GetPhotonView().viewID +"\nIsActive: " + player.GetActive());
        //create to spawn points 
    }

    void OnLeftRoom()
    {
        //PhotonNetwork.
        Debug.Log("Player #: " + player.GetPhotonView().viewID + " has left the room");
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
