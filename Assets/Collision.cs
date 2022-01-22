using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor=new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor=new Color32(1,1,1,1);
[SerializeField] float time_delay=0.2f;
SpriteRenderer sp;
bool has_package=false;
    // Start is called before the first frame update
    void Start()
    {
        sp=GetComponent<SpriteRenderer>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // 
    //checkigng



//time delay for the package to get destroyed


     void OnCollisionEnter2D(Collision2D other) {
Debug.Log("Hey there it is a collision");//for the collision 
     }

 void OnTriggerEnter2D(Collider2D other) {
   //checking for the package and the customer
   if(other.tag=="package" && has_package==false){
       Debug.Log("Package picked up");
       has_package=true;
       //changing the color
       sp.color=hasPackageColor;
       Destroy(other.gameObject,time_delay);
   }
   else if((other.tag=="customer") &&( has_package==true))
   {
    Debug.Log("Package delivered");
    has_package=false;    
    sp.color=noPackageColor;
   }

}

         
    }

