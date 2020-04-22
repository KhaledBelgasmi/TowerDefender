using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;
    //This allows you to quickly reference GameObjects by dragging and dropping onto the script in Unity

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
        //projectile is the game object to be instantiated at the position of 
        //the gun game object and with the rotation of the cactus which is zero
    }
}
