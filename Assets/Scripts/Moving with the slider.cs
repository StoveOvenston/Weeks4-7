using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingwiththeslider : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Movment() {
                Vector3 pos = transform.position;
        pos.x += speed;
        transform.position = pos;
    }
}
