using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
public class Shield : MonoBehaviour
{
    public float speed = 7;
    private float leftEdge;
    public  GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f;
        GM = GameObject.FindGameObjectWithTag("Player").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
         transform.position += Vector3.left*speed*Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
        
        
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("shieldtaken");
            Destroy(gameObject);
        }
    }
   
}
