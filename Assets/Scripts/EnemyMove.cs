 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 public class EnemyMove : MonoBehaviour
 {
   private Vector3 startPos;
    public GameObject Player;
    bool isDead;
    public Transform target;
    public float speed;
    private bool moveUp;
    void Start()
    {
       startPos = transform.position;
        moveUp = true;
        isDead = false;
    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (transform.position == target.position)
        {
            moveUp = false;
        }
        else if (transform.position == startPos)
        {
            moveUp = true;
        }
        if(moveUp == false)
        {
            transform.position = Vector3.MoveTowards (transform.position, startPos, step);
        }
        else if (moveUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
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