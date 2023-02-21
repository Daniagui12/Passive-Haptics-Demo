using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
   float drag = 0.01; // drag factor
   private Rigidbody rb;

   void Start(){
     rb = GetComponent<Rigidbody>();
   }

   void FixedUpdate(){
     var vel = rigidbody.velocity;
     vel.x *= 1.0-drag; // reduce x component...
     vel.z *= 1.0-drag; // and z component each cycle
     rigidbody.velocity = vel;
   }
}
