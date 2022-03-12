using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHealth : MonoBehaviour
{
    public int health;


   private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.name == ("Health"))

        {
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
            health++;
        }

        if (collision.gameObject.name == "Damage")
        {
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
            health--;
        }

           

               
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
