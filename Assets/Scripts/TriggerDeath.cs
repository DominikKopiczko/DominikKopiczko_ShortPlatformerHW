using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDeath : MonoBehaviour
{
    public GameObject Player;
    bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true){
            Restart();
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    { 
        Destroy(Player);
        isDead = true;
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

