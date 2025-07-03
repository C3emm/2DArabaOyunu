using System.Collections;
using System.Collections.Generic; // Coroutine kullanmak için gerekli
using UnityEngine;
using UnityEngine.UI;//arayüz elemanını kontrol etmek için gerekli

public class ScoreTable : MonoBehaviour
{
    public int score = 0;// Skor değişkeni
    public Text scoreText; // Skoru göstermek için UI Text bileşeni
    void Start()
    {
        StartCoroutine(ScoreCoroutine());//skoru arttırmak için Coroutine başlatılır
    }
    void Update()
    {
        scoreText.text = score.ToString(); // Skoru UI Text bileşenine atar.Çünkü iki tarafı da int ya da string yapmak lazım
    
    }
    IEnumerator ScoreCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);//kısaca her saniye skoru arttırmak için yapılan dizi
            score++;
            Debug.Log("Score: " + score);
        }
    }
} 