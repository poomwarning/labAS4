using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankcontroll : MonoBehaviour
{
   public float speed;
   public float rotationspeed;

   private void Update() 
   {
      if(Input.GetKey(KeyCode.W))  
      {
         transform.Translate(Vector3.forward* Time.deltaTime*speed,Space.Self);
         
      }
       if(Input.GetKey(KeyCode.S))  
      {
         transform.Translate(Vector3.back* Time.deltaTime*speed,Space.Self);
      }
      if(Input.GetKey(KeyCode.A))  
      {
         transform.Rotate(Vector3.up* Time.deltaTime*rotationspeed);
      }
       if(Input.GetKey(KeyCode.D))  
      {
         transform.Rotate(Vector3.down* Time.deltaTime*rotationspeed);
      }
   }


}
