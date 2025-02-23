using UnityEngine;
using Photon.Pun;
using TMPro;

public class AvatarNameDisplay : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var nameLabel = GetComponent<TextMeshPro>();

        //�v���C���[���ƃv���C���[ID��\������
        nameLabel.text = $"{photonView.Owner.NickName}({photonView.OwnerActorNr})";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
