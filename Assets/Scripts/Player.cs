using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    public int health = 3;
    public int Score = 0;

    public Text txt_Health;
    public Text txt_Score;

    public Canvas UI;
    public Canvas GameOver;


    // Start is called before the first frame update
    void Start()
    {
        txt_Health.GetComponent<Text>();
        txt_Score.GetComponent<Text>();
        UI.GetComponent<Canvas>();
        GameOver.GetComponent<Canvas>();
        GameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        txt_Health.text = "Health: " + health.ToString();
        txt_Score.text = "Score: " + Score.ToString();
        if (health <= 0)
        {
            GameOver.enabled = true;
            UI.enabled = false;
            Invoke("Restart", 3f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        health--;
        Destroy(collision.gameObject);
    }

    void Restart()
    {
        SceneManager.LoadScene("Scene01");
    }
}
