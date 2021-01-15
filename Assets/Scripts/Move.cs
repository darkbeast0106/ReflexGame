using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private GameObject player;
    private Player playerScript;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<Player>();
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == gameObject.tag)
        {
            playerScript.Score++;
        }
        else
        {
            playerScript.health--;
        }
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
