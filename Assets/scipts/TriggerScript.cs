using UnitySystem.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void OnTriggerEnter(Collider other);// is callled when an object enters the trigger 
        void OnTriggerStay(Collider other); // is called when an object stays in the trigger 
        void OnTriggerExit(Collider other); // is called when an object exits the trigger    
        void OnTriggerEnter(Collider other);
    }
}
{ 
    print("Object has entered collider");
} 


}
void OnTriggerEnter(Collider other);
    // Update is called once per frame
    void Update()
    {
    print(other.gameObject.Cube + " Cube has entered the trigger");
    }
}
