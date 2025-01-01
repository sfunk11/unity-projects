using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;
   private void OnCollisionEnter(Collision other) 
   {
        hits++;
        Debug.Log("You have bumped into something this many times: " + hits);
   }
}
