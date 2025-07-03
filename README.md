2D Araba Oyunu - Unity Projesi

Bu proje, Unity oyun motorunu kullanarak geliştirdiğim basit ama eğlenceli bir 2D araba oyunudur. Oyunu yukarıdan bakış açısıyla (top-down) tasarladım. Oyuncunun amacı, yolda ilerlerken aracını sağa veya sola hareket ettirerek karşısına çıkan engellerden ve diğer araçlardan kaçmak. Mümkün olduğunca uzun süre hayatta kalıp yüksek skor yapmak üzerine kurulu bir oyun. Mantık olarak, mobil cihazlarda çok popüler olan sonsuz koşu (endless runner) türüne yakın bir oynanışa sahip. Özellikle Traffic Rider oyunundan esinlendim diyebilirim.

Oyun Nasıl İşliyor?

Oyuncunun aracı aslında oyun sahnesinde sabit kalıyor ama yol ve çevredeki nesneler sürekli yukarı doğru hareket ediyor. Böylece oyuncuya, aracın ileri doğru sürdüğü hissi veriliyor. Oyuncu Android telefonun ekranına sağa veya sola dokunarak arabayı yönlendiriyor. Yolda ilerlerken karşısına çıkan çeşitli engeller ve araçlar bulunuyor. Eğer engellere çarparsa oyun bitiyor. Oyuncu, oyunda ne kadar uzun kaldıysa veya ne kadar mesafe kat ettiyse skor ona göre artıyor. Oyun bittiğinde skor ekranda gösteriliyor ve oyuncu istediği zaman yeniden başlayabiliyor.

Projede Bulunan Kod Dosyalarının Detaylı Anlatımı

PlayerMovement.cs

Bu script, oyuncunun arabayı sağa ve sola hareket ettirmesini sağlıyor.  
- Telefon ekranına dokunma gibi girişleri algılıyor.  
- Bu girişlere göre arabanın yatay eksende hareket etmesini sağlıyor.  
- Arabanın yol dışına çıkmaması için sınırlar koydum.  
- Hareketin yumuşak ve gerçekçi görünmesi için hız ve kontrol ayarları var.  
Kısaca, oyuncu aracı nasıl kullanacaksa onun temel kontrol mekanizmasını bu dosyada yazdım.

 yukariHareket.cs

Burada yol ve yol üzerindeki nesnelerin sürekli yukarı doğru hareket etmesini sağlıyorum.  
- Nesneler sürekli yukarı hareket ederek oyuncuya aracın ileri doğru gittiği hissini verir.  
- Ekranın üst kısmından çıkan nesneler tekrar başa dönerek sonsuz bir döngü oluşturuyor.  
- Bu sayede yol kesintisiz bir şekilde akıyor gibi gözüküyor.

yolHareketi.cs

Bu script, yolun dokusunun yani zemindeki görsel katmanın sürekli yukarı doğru hareket etmesini sağlıyor.  
- Yol kaplaması yukarı doğru kaydırılarak ilerleme hissi güçlendiriliyor.  
- Doku sürekli yenilenerek kesintisiz bir arka plan oluşturuluyor.  
- Bu efekt, oyuncunun oyundaki ilerlemesini daha belirgin hale getiriyor.

gamecontroller.cs

Oyunun genel akışını ve yönetimini bu script yapıyor.  
- Oyunun başlaması, durması ve yeniden başlatılması gibi durumlar burada kontrol ediliyor.  
- Araba bir engelle çarpıştığında oyunu durduruyor ve skorun gösterilmesini sağlıyor.  
- Oyuncunun tekrar oyuna başlaması için gerekli fonksiyonları burada bulabilirsin.  
Oyun içindeki temel yönetim işlerini bu script üstleniyor.

skorTablosu.cs

Bu dosya, oyuncunun skorunu takip edip ekranda göstermeyi sağlıyor.  
- Oyuncu oyunda kaldıkça skor artıyor.  
- Oyun sona erdiğinde toplam skor ekranda kalıyor.  
- İleride yüksek skor kaydı gibi özellikler eklemek için burası uygun yer.  
Skor sistemiyle ilgili her şey bu scriptte yer alıyor.

NewMonoBehaviourScript.cs

Bu script şu anda boş ya da deney amaçlı kullanılıyor.  
- Unity yeni script oluşturduğunda otomatik olarak böyle bir dosya açabiliyor.  
- İleride yeni özellikler eklemek için denemeler yapabileceğim bir dosya olarak duruyor.

Projenin Amacı ve Öğrendiklerim

Bu projeyi Unity’de 2D oyun geliştirme konusunda temel pratik yapmak için yaptım.  
Özellikle:  
- Oyuncunun hareket kontrolünü sağlama,  
- Sonsuz yol efekti yaratma,  
- Çarpışma algılama ve oyunu bitirme,  
- Skor tutma ve göstermek,  
- Oyun akışını düzenleme gibi temel oyun mekaniklerini öğrenmek istedim.

Açıkçası, bu proje hem kendi becerilerimi geliştirmek hem de Traffic Rider gibi oyunları seven arkadaşlar için güzel bir örnek oluşturmak amacıyla ortaya çıktı. Unity’de C# kullanarak sahne yönetimi ve oyun mantığı oluşturmak için temel bir altyapı sağlıyor.

Kodları mümkün olduğunca sade ve anlaşılır yazmaya çalıştım. Böylece ileride isteyen herkes kolayca yeni özellikler ekleyebilir veya değiştirebilir.
