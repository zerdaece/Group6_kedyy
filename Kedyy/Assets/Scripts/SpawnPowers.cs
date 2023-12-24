using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowers : MonoBehaviour
{
  


    public GameObject[] engelPrefabArray; // Mevcut engel prefab'larını içeren dizi
    public float spawnRate = 2f; // Engeller arasındaki boşluk
    public float engelHizi = 5f; // Engel hızı

    private float timer = 0f;

    void Update()
    {
       if (timer < spawnRate)
    {
        timer += Time.deltaTime;
    }
    else
    {
        float randomNumber = Random.Range(0f, 1f);
        
        // Spawn olma olasılığını belirleyen eşik değeri (örneğin, 0.5 50% olasılık demektir)
        float spawnThreshold = 0.5f;

        if (randomNumber > spawnThreshold)
        {
            RastgeleEngelSpawnla();
        }

        timer = 0f;
    }
    }

    void RastgeleEngelSpawnla()
    {
        int rastgeleIndex = Random.Range(0, engelPrefabArray.Length); // Mevcut prefab'lardan rastgele birini seç

        //float rastgeleY = 0f; // Engellerin yükseklik aralığı

        GameObject yeniEngel = Instantiate(engelPrefabArray[rastgeleIndex], new Vector3(10f, 0, 0f), Quaternion.identity);
        // Quaternion.identity, rotasyon olmadan objeyi oluştur demektir.

        Destroy(yeniEngel, 10f); // 10 saniye sonra engeli yok et
        /*Rigidbody2D rb = yeniEngel.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-engelHizi, 0f); // Engel hızını ayarla*/
    }
}

