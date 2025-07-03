using UnityEngine;
using System.Collections;

public class carSpawn : MonoBehaviour
{
    public GameObject[] car;

    void Start()
    {
        StartCoroutine(SpawnCar()); // Coroutine başlatılıyor
    }

    void cars()
    {
        int rand = Random.Range(0, car.Length); // kaç tane araba spawn edileceği
        float randXpos = Random.Range(-1.44f, 1.44f); // x pozisyonu

        Instantiate(car[rand], new Vector3(randXpos, transform.position.y, 0), Quaternion.identity);
    }

    IEnumerator SpawnCar()
    {
        while (true)
        {
            yield return new WaitForSeconds(1); // her 2 saniyede bir araç oluşturur.
            cars();
        }
    }
}
