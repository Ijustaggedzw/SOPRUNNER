using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
  
    // When something enters the trigger attached to this gameobject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "CleanUp")
        {
            //then we use this method to destroy it
            Destroy(collision.gameObject);
        }

        // Update is called once per frame
    }
    
        
    
}
