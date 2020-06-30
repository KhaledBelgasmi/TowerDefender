using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        FindObjectOfType<LivesDisplay>().TakeLife();
    }
    //no argument is passed to this method because only enemies will ever hit the damage collider
    
}
