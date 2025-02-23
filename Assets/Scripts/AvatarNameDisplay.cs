using UnityEngine;
using Photon.Pun;
using TMPro;

public class AvatarNameDisplay : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var nameLabel = GetComponent<TextMeshPro>();

        //プレイヤー名とプレイヤーIDを表示する
        nameLabel.text = $"{photonView.Owner.NickName}({photonView.OwnerActorNr})";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
