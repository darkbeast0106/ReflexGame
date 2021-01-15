using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Triangle;
    public GameObject Square;
    public GameObject FirePoint;
    private Vector3 position;
    private void Start()
    {
        var position = FirePoint.transform.position;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(Circle, new Vector3(position.x, position.y, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(Triangle, new Vector3(position.x, position.y, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Square, new Vector3(position.x, position.y, 0), Quaternion.identity);
        }

    }
}
