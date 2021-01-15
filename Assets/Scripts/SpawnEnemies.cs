using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField]
    private float timeDuration = 1;
    private float timeout = 2;

    public GameObject Circle;
    public GameObject Triangle;
    public GameObject Square;
    public GameObject SpawnPoint;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = SpawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeout > 0)
        {
            timeout -= Time.deltaTime;
            return;
        }
        Spawn();
        timeout = timeDuration;
    }
    private void Spawn()
    {
        int rnd = Random.Range(1, 4);
        if (rnd == 1)
        {
            Instantiate(Circle, new Vector3(position.x, position.y, 0), Quaternion.identity);
        }
        if (rnd == 2)
        {
            Instantiate(Triangle, new Vector3(position.x, position.y, 0), Quaternion.identity);
        }
        if (rnd == 3)
        {
            Instantiate(Square, new Vector3(position.x, position.y, 0), Quaternion.identity);
        }
    }
}
