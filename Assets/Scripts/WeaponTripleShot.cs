using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTripleShot : WeaponBase {

    /// <summary>
    /// Shoot will spawn a three bullets, provided enough time has passed compared to our fireDelay.
    /// </summary>

    public override void Shoot() 
    {
        
        float currentTime = Time.time; // get the current time
          // if enough time has passed since our last shot compared to our fireDelay, spawn our bullet
      
        if (currentTime - lastFiredTime > fireDelay) 
        {
            float x = -0.5f;
            
            for (int i = 0; i < 3; i++) // create 3 bullets 
            {
                GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation); // create our bullet

                newBullet.GetComponent<MoveConstantly>().Direction = new Vector2(x + 0.5f * i, 0.5f); // set their direction
            }
            
            print("Shoot triple shot");

            lastFiredTime = currentTime;  // update our shooting state
        }
    }
}
