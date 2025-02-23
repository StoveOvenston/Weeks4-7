using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SLider : MonoBehaviour
{
   public Slider slider; // Slider for reference
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
// transforms the size of the object relative to the sliders value
        transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }
}
