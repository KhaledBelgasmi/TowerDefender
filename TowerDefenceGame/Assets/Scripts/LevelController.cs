using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    int numberOfattackers = 0;
    bool levelTimerFinished = false;
    
    public void AttackerSpawned()
    {
        numberOfattackers++;        
    }

    public void AttackerDestroyed()
    {
        numberOfattackers--;
        if (numberOfattackers <= 0 && levelTimerFinished)
        {
            Debug.Log("End level now");
        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
