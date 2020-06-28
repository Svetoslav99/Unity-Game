using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //refference to the Transform component in Unity called player.
    public Transform player;
    public Vector3 offset; //stores 3 float numbers (x,y,z)

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
