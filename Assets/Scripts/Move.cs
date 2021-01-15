using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Fixed Update called once in a fixed interval. It doesn't affected by framerate.
    private void FixedUpdate()
    {
        transform.Translate(3 * Time.deltaTime, 0, 0);
    }
}
