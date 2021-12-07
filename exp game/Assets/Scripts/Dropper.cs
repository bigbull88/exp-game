using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    [SerializeField] float timeToWait = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer. enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
           // GetComponent<Rigidbody>().usegravity = enable;
            Debug.Log("Time to fall: 3s elapsed" );
        }
        
    }
}
