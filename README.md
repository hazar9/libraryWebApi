# 📚 Library API

.NET 8 kullanılarak geliştirilmiş, katmanlı mimariye (Layered Architecture) sahip bir kütüphane yönetim sistemi Web API projesidir.

## 🚀 Özellikler

- **Katmanlı Mimari:** Models, Data, Repositories, Services ve Controllers yapısı.
- **CRUD İşlemleri:** Kitaplar (Books) ve Kategoriler (Categories) için tam yönetim.
- **Gelişmiş Listeleme:** Kitaplar için filtreleme (isim ve yazar), sıralama ve sayfalama (pagination) desteği.
- **İlişkisel Veritabanı:** Kategori ve Kitap arasında bire-çok (one-to-many) ilişki.
- **Hazır Veri (Data Seeding):** Proje ilk çalıştığında otomatik yüklenen örnek test verileri.
- **API Dokümantasyonu:** Swagger arayüzü ile tüm uç noktaları (endpoints) kolayca test etme imkanı.

## 🛠 Kullanılan Teknolojiler

- C# / .NET 8 Web API
- Entity Framework Core (Code-First)
- SQLite Veritabanı
- Swagger / OpenAPI