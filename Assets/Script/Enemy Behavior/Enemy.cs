using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    //GameObject enemy is moving towards
    public GameObject Heart;
    [SerializeField]
    private float moveSpeed = 2f;
    public GameManager gameManager;



    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, Heart.transform.position, moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Heart")
        {
          FindObjectOfType<GameManager>().EndGame();
           
        }
    }



}
