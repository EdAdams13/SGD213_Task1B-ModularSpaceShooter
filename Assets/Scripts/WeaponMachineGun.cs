using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMachineGun : WeaponBase 
{
    /// <summary>
    /// Shoot will spawn a new bullet, provided enough time has passed compared to our fireDelay.
    /// </summary>

    public override void Shoot() 
    {
        
        float currentTime = Time.time; // get the current time
        
        
        if (currentTime - lastFiredTime > fireDelay) // if enough time has passed since our last shot compared to our fireDelay, spawn our bullet
        {
            GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation); // create our bullet
        
            lastFiredTime = currentTime;  // update our shooting state
            
            print("Shoot Machine Gun");
        }
    }
}
