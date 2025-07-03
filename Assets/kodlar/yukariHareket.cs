using UnityEngine;

public class YukariHareket : MonoBehaviour
{

    public float speed = 1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed * Time.deltaTime, 0); // Başlangıçta oyuncunun konumunu yukarıya doğru hareket ettiriyoruz ve bu hıza sahip olan araçları aşağya gönderiyoruz
       
       if(transform.position.y < -6f) // Eğer araç ekranın altına geçerse
       {
           Destroy(gameObject); // O aracı yok et
       }
    }

}
