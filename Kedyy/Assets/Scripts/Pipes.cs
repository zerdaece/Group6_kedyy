
using JetBrains.Annotations;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5;
    private float leftEdge;
    // Start is called before the first frame update
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f;
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
    public void SpeedI()
    {
        transform.position += Vector3.left*(speed*2)*Time.deltaTime;
        
    
    }
    
}
