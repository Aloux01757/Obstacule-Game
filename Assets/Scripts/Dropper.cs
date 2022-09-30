using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rederer;
    
    [SerializeField]float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rederer = GetComponent<MeshRenderer>();
        

        rederer.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
      if(Time.time > timeToWait)
      {
        Debug.Log("It passed 3 seconds!");
      }
    }
}
