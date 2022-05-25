using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
   private BoxCollider2D boxCollider;
    
   private void Start()
   {
    boxCollider=GetComponent<BoxCollider2D>();
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
