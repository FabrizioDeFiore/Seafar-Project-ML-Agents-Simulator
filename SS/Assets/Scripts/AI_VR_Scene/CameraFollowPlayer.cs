using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    //public GameObject player;
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    // Start is called before the first frame update
    void Start(){
        //player = GameObject.Find("VasselAgent"); // The player
    }

    // Update is called once per frameS
    void LateUpdate(){
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 50, player.transform.position.z - 100);
        if (target != null){
        Vector3 desiredPosition = target.localPosition + offset;
        transform.localPosition = Vector3.Lerp(transform.localPosition, desiredPosition, smoothSpeed);
        transform.localRotation = Quaternion.Euler(25f, target.localRotation.eulerAngles.y - 180f, 0f);
        }
    }
}
