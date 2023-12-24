using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class IncreasedSpeed : MonoBehaviour
{
     //public float speed = 7;
    private float leftEdge;
  
    public float SpeeedincreaseSpeed = 5;
    public float speedMultiplier = 1.5f;
    public float speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Speedincreasedtaken");
            Destroy(gameObject);
            speed= 10;
        }
    }
    void Update()
    {
         transform.position += Vector3.left*speed*Time.deltaTime;
       
        
        
    }
   
}
