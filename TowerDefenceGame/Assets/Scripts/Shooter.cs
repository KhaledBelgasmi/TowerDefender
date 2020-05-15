using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
   
    //This allows you to quickly reference GameObjects by dragging and dropping onto the script in Unity


    private void Start()
    {
        SetLaneSpawner();
    }

    public void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("Shooting");
            //TODO change animation state to shooting
        }
        
        else
        {
            Debug.Log("sit and wait");
            //TODO change animation state to idle
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {

        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        } 
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
        //projectile is the game object to be instantiated at the position of 
        //the gun game object and with the rotation of the cactus which is zero
    }
}
