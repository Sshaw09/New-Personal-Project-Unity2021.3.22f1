using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the position of the player and adds the camera positioned following it
        transform.position = player.transform.position + new Vector3(1, 9, -9);
        
    }
}
