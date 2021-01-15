using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(-3 * Time.deltaTime, 0, 0);
    }
}
