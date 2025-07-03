using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Coroutine kullanmak için gerekli
using UnityEngine.UI; // Arayüz elemanını kontrol etmek için gerekli
using UnityEngine.SceneManagement; // Sahne yönetimi için gerekli

public class gamecontroller : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void Restart() // Oyunu yeniden başlatmak için bir fonksiyon
    {
        SceneManager.LoadScene("SampleScene"); // "SampleScene" sahnesini yeniden yükler
    }
}
