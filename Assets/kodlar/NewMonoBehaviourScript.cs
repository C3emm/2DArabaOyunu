using UnityEngine;

public class yolHareketi : MonoBehaviour
{
    public Renderer meshRenderer;//materyali kontrol ediyor ve erişmek için yapıyoruz.
    public float harekethizi = 0.5f;//hizi unityden ayarlamak için public ile yazıyoruz
    void Start()
    {

    }

    void Update()
    {

        meshRenderer.material.mainTextureOffset += new Vector2(0, harekethizi * Time.deltaTime); //mesh rendererdan materiala erişip aracın hızıyla birlikte y ekseninin hareket etmesini sağıyoruz.Time.deltaTime ile tüm cihazlarda aynı hızda hareket etmesini sağlıyoruz.
         



    }
    
}
