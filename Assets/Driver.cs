using System.Collections;//namespaces
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour//blue print
{
    //initilising variables
    [SerializeField] Color32 hasPackageColor=new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor=new Color32(1,1,1,1);
    [SerializeField] float turn_speed=200;
    [SerializeField] float move_speed=10;
    //reference of the spriteremdered
    //slowing and increasing speed
    [SerializeField] float slow=5f;
    [SerializeField] float fast=20f;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()

    {
        //getting the input

        //creating the local varibale

        float turn_amount=Input.GetAxis("Horizontal")*turn_speed* Time.deltaTime;
        //for the vertical axis

        float Rotate_amount=Input.GetAxis("Vertical")*move_speed* Time.deltaTime;


transform.Rotate(0,0,-turn_amount);
transform.Translate(0,Rotate_amount,0);

    
}
 void OnTriggerEnter2D(Collider2D other) {
         if(other.tag=="booster"){
move_speed=fast;

         }
         if(other.tag=="slower"){
             move_speed=slow;

         }
        
    }
        
    }
