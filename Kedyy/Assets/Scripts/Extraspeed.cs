using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extraspeed : MonoBehaviour
{
    public float speed = 5f; // Başlangıç hızı
    public float acceleration = 1f; // Hız artış miktarı
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            // Hızı arttır
            speed += acceleration * Time.deltaTime;

            // Kuşun yukarı doğru hareketi
            if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButton(0))
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            }
        }
    }
}
