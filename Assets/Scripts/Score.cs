using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
          if(other.gameObject.tag != "Hit") //No equal Hit
          {
            hits++;
            Debug.Log("You've already collided so :" + hits + "Times!");
          }
       
    }
}
