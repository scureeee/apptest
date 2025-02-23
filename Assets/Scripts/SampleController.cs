using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class SampleController : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //プレイヤー自身の名前を"Player"に設定する
        PhotonNetwork.NickName = "Player";

        //PhotonServerSettingsの設定内容を使ってマスターサーバーへ接続する
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        // "Room"という名前のルームに参加する(ルームが存在しなければ作成して参加する)
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        //ランダムな座標に自身のアバター（ネットワークオブジェクト）を生成する
        var position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        PhotonNetwork.Instantiate("Avatar", position, Quaternion.identity);
    }
}
