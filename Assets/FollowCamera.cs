using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    //the cameras position should be same as the cars position
    [SerializeField] GameObject thingtofollow;          
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {


        transform.position=thingtofollow.transform.position+new Vector3(0,0,-10);

        
    }
}
