using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rederer; // caching reference
    Rigidbody rb; // caching reference
    [SerializeField]float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rederer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rederer.enabled = false;
        rb.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
      if(Time.time > timeToWait)
      {
        rederer.enabled = true;
        rb.useGravity = true;
      }
    }
}
