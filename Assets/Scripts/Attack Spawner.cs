using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    float speed = 0.1f;
    //public gameobjects to be referenced
    public GameObject Fireball; 
    public GameObject Lightningbolt;
    //Spawned objects
    GameObject fireball;
    GameObject lightningbolt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (fireball != null) {
           speed = .1f;
       Vector3 fireballPosition = fireball.transform.position;
        fireballPosition.x -= speed;
        fireball.transform.position = fireballPosition;
        if (fireballPosition.x <= -4.72f) {
        Destroy(fireball);
        }
    }
    }
    public void spawnFireball() {
        fireball = Instantiate(Fireball);
    }
      public void spawnLightningbolt() {
        lightningbolt = Instantiate(Lightningbolt);
    }

}

