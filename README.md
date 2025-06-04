Proje adı:kelime_ezberleme 
Bu proje, Scrum yöntemiyle geliştirilen bir **kelime ezberleme uygulamasıdır**. Öğrencilerin İngilizce kelimeleri kalıcı şekilde öğrenmesini amaçlar. C# diliyle yazılmıştır ve kullanıcılar kelimeleri ses, resim ve örnek cümlelerle çalışabilir.


## 🧠 Proje Özeti

- ✅ **Tekrar algoritması:** 6 sefer üst üste doğru bilinen kelime ezberlenmiş sayılır.
- ✅ **Zaman aralıklı tekrar:** 1 gün, 1 hafta, 1 ay, 3 ay, 6 ay, 1 yıl.
- ✅ **Kullanıcı yönetimi**: Kayıt, giriş, şifre sıfırlama.
- ✅ **Kelime ekleme**: Resim, örnek cümle ve ses desteğiyle.
- ✅ **Sınav modülü**: Rastgele ve zaman tabanlı kelime testi.
- ✅ **Ayarlar modülü**: Günlük çıkacak yeni kelime sayısını belirleme.
- ✅ **Analiz raporu**: Başarı yüzdesi ve konulara göre analiz.
- ✅ **Bulmaca (Wordle) modu**: Ezberlenen kelimelerden oyun oluşturur.

---

## 🛠 Kullanılan Teknolojiler

- ✅ C# (WinForms)
- ✅ MSSQL (veritabanı)
- ✅ Entity Framework (isteğe bağlı)
- ✅ Trello (Scrum yönetimi)
- ✅ GitHub (versiyon kontrolü)
- ✅ SonarQube (Kod kalitesi analizi)

---



## 🧪 Ezber Algoritması

1. Her kelimenin doğru bilindiği sefer sayısı izlenir.
2. Üst üste 6 doğru yanıt verilmediyse sayaç sıfırlanır.
3. Her doğru bilinen kelime, 6 farklı tarihte tekrar sorulur.
4. 6. tekrar da doğruysa **“bilinen kelime” havuzuna taşınır**.

---

## 📊 Kullanıcı Analizi

- Kullanıcının en başarılı olduğu konular yüzdesel olarak listelenir.
- İstendiğinde PDF veya yazdırılabilir ekran çıktısı alınabilir.

---

## 🎮 Wordle (Bulmaca) Modülü

- Öğrencinin ezberlediği kelimelerden rastgele seçilir.
- Wordle mantığıyla kelime tahmini yapılır.
- Harf doğruysa yeşil, yer yanlışsa sarı gibi görsel geri bildirim sağlanır.

---



## 📝 Kurulum ve Çalıştırma

1. Bu projeyi klonlayın:
   ```bash
   git clone https://github.com/aysenurerenm/kelime_ezberleme.git 
