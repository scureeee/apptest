using UnityEngine;
using Photon.Pun;

public class AvatarController : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //自身が生成したオブジェクトだけに移動処理を行う
        if(photonView.IsMine)
        {
            var input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
            transform.Translate(6f * Time.deltaTime * input.normalized);
        }
    }
}
