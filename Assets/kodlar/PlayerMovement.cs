using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float screenWidth; //ekran genişliği 

    public GameObject gameOverPanel; //Game Over paneli

    void Start()
    {
        Time.timeScale = 1; //oyunun zamanını başlatır
        gameOverPanel.SetActive(false); //Game Over panelini başlangıçta gizler
        screenWidth = Screen.width; // Ekran genişliğini alıyoruz
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)//kullanıcının ekrana dokunup dokunmadığını kontrol eder
        {
            Touch touch = Input.GetTouch(0); //ilk dokunuşu alır

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary) //dokunma başladığında veya dokunma devam ediyosa onu algılar 
            {

                if (touch.position.x < screenWidth / 2) //dokunma ekranın bir yarısındaysa eğer onu algılamak için kullanılır
                {
                    transform.position += new Vector3(speed * Time.deltaTime, 0, 0); //sağa hareket ettirmek için.

                }
                if (touch.position.x > screenWidth / 2) //dokunma ekranın diğer yarısındaysa eğer onu algılamak için kullanılır
                {
                    transform.position -= new Vector3(-speed * Time.deltaTime, 0, 0); //sola hareket eder çünkü transformdaki x eksenine göre hareket ettiriyoruz
                }
            }


        }

        Vector3 vec = transform.position; //transformdaki konumu alıyoruz
        vec.x = Mathf.Clamp(vec.x, -1.44f, 1.44f); //x eksenini -1.44 ile 1.44 arasında sınırlandırıyoruz çünkü ekran dışına çıkmasını istemiyoruz
        transform.position = vec; //değerleri birbirine eşitliyoruz
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "car") //car tagli objeye çarptığında otomatik olarak oyunu bitirir.
        {
            Time.timeScale = 0; //oyunun zamanını durdurur
            gameOverPanel.SetActive(true); //Game Over panelini aktif eder
        }
    }

}




