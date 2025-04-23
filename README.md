# Görev Yöneticisi Web API Projesi

Bu proje, kullanıcıların günlük, haftalık ve aylık görevlerini yönetebileceği, JWT ile kimlik doğrulama destekli bir .NET Core Web API uygulamasıdır. Uygulama Swagger UI üzerinden test edilebilir, görevler kullanıcıya özel saklanır.

---

## 🚀 Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| **ASP.NET Core Web API** | Modern ve hızlı API geliştirme framework'ü |
| **Entity Framework Core** | Veritabanı işlemleri için ORM |
| **MSSQL** | İlişkisel veritabanı yönetim sistemi |
| **JWT (Json Web Token)** | Güvenli kullanıcı giriş ve yetkilendirme |
| **Swagger / Swashbuckle** | API dokümantasyonu ve test arayüzü |
| **LINQ** | Veritabanı sorguları için C# destekli yapısal sorgular |

---

##Katmanlar ve Yapı

- `Controllers` → API uç noktaları (`Users`, `Auth`, `Tasks`)
- `Models` → Veritabanı modelleri (`User`, `TaskItem`)
- `Data` → EF Core `AppDbContext`
- `appsettings.json` → Veritabanı ve JWT ayarları
- `Program.cs` → Servis tanımları ve middleware sıralaması

---

##  Authentication Akışı

1. `POST /api/auth/register` → Kullanıcı kayıt
2. `POST /api/auth/login` → Token al
3. `Authorize` → Swagger üzerinden token'ı gir
4. `GET /api/tasks` → Sadece token'lı kullanıcı görür
5. `POST /api/tasks` → Sadece giriş yapan kullanıcı görev oluşturabilir

---

## Veritabanı Tabloları

- `Users`  
  - `Id`, `Username`, `Email`, `PasswordHash`, `PasswordSalt`
- `Tasks`  
  - `Id`, `Title`, `Description`, `Category`, `CreatedAt`, `UserId`

---

## Nasıl Çalıştırılır?

1. Visual Studio ile aç
2. `appsettings.json` içindeki connection string'i kendi SQL instance'ına göre düzenle
3. Aşağıdaki komutları sırayla çalıştır:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   dotnet run
