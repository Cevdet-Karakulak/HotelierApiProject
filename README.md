# 🏨✨ Kurumsal Otel Rezervasyon RESTful API Projesi ✨🏨

Bu proje, Murat Yücedağ hocanın Udemy’deki “ASP.NET Core API - RapidAPI ve API Consume” eğitimi temel alınarak, **REST prensiplerine uygun**, **tam kapsamlı bir otel rezervasyon ve yönetim sistemi** olarak geliştirilmiştir.  
Backend işlemleri tamamen **ASP.NET Core Web API** ile sağlanmış, **MVC tabanlı frontend** ile entegre edilmiştir.  

**Hedef:** Kurumsal bir otel rezervasyon sisteminin, **gerçek dünya senaryolarına** uygun şekilde N-Katmanlı mimari kullanılarak geliştirilmesi.  

---

  ## 🛠️ Kullanılan Teknolojiler

<p align="center">
  <img src="https://img.shields.io/badge/.NET%207-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=entity-framework&logoColor=white" />
  <img src="https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
  <img src="https://img.shields.io/badge/JWT-000000?style=for-the-badge&logo=jsonwebtokens&logoColor=white" />
  <img src="https://img.shields.io/badge/FluentValidation-007ACC?style=for-the-badge&logo=fluentbit&logoColor=white" />
  <img src="https://img.shields.io/badge/RapidAPI-0052CC?style=for-the-badge&logo=rapidapi&logoColor=white" />
</p>

---

## 📋 Temel Özellikler

### 🧩 **Kurumsal Mimari (6 Katmanlı Yapı)**
- **API Layer:** REST endpoint’leri  
- **Business Layer:** İş kuralları & Validasyon  
- **Data Access Layer:** EF Core ile veri işlemleri  
- **Entity Layer:** Varlık (Entity) ve DTO tanımları  
- **Presentation Layer:** MVC tabanlı UI  
- **Core Helpers:** Ortak servis ve yapılandırmalar  

### 🛠️ **Admin Paneli**
- Dashboard: Toplam rezervasyon, kullanıcı, oda, personel istatistikleri  
- Rezervasyon yönetimi (Onay / İptal / Beklet)  
- Personel, oda, müşteri, hizmet, referans, lokasyon CRUD işlemleri  
- Gelen kutusu: Kullanıcılardan gelen mesajları görüntüleme ve yanıtlama  
- Rol & kullanıcı yönetimi (Rol atama dahil)  
- Görsel & dosya yönetimi  
- Profil ayarları  

### 👤 **Kullanıcı Paneli**
- Şehre, giriş/çıkış tarihine ve kişi sayısına göre **otel arama**  
- Otel odaları & detaylarını inceleyerek **rezervasyon yapma**  
- **Mail bülteni** aboneliği  
- **İletişim formu** üzerinden yöneticilere mesaj gönderme  

### 🔐 **Kimlik Doğrulama & Yetkilendirme**
- **Identity & JWT** tabanlı authentication  
- **Role-based Authorization** (Admin & User yetkileri)  

### 📧 **Mail Servisi**
- SMTP üzerinden **dinamik mail gönderimi** (rezervasyon onayı, bilgilendirme mailleri)  

### ⚡ **RapidAPI Entegrasyonu**
- Instagram, LinkedIn, Twitter gibi sosyal medya API’lerinden dinamik veri çekme  

---

## 🗃️ Projede Yer Alan Başlıca Entityler
- **Booking** – Rezervasyonlar  
- **Room** – Odalar  
- **Guest** – Misafirler  
- **Staff** – Personel  
- **MessageCategory** – Mesaj kategorileri  
- **SendMessage** – Gönderilen mesajlar  
- **Service** – Otel hizmetleri  
- **Testimonial** – Müşteri yorumları  
- **Subscribe** – Mail bülteni abonelikleri  
- **WorkLocation** – Otel lokasyonları  
- **AppUser & AppRole** – Kullanıcı & Roller  

---

## 📸 Ekran Görüntüleri
><img width="1456" height="908" alt="Image" src="https://github.com/user-attachments/assets/e0fb5e4e-d70e-445a-8d1c-5e6e3e153e8a" />

<img width="649" height="806" alt="Image" src="https://github.com/user-attachments/assets/926aaea8-cc66-4d00-b4a8-4c6634927887" />

<img width="1456" height="815" alt="Image" src="https://github.com/user-attachments/assets/866bdb28-7449-4003-b5b6-11ade562e0a9" />

<img width="1426" height="910" alt="Image" src="https://github.com/user-attachments/assets/5de6ca02-fbc5-4f06-8378-e3a10a299923" />

<img width="1437" height="907" alt="Image" src="https://github.com/user-attachments/assets/780d94c7-6df2-4385-996c-07020fd2d32d" />

<img width="1328" height="535" alt="Image" src="https://github.com/user-attachments/assets/1f8e1781-8ef8-436e-a535-ff8ab4bffbad" />

<img width="1317" height="904" alt="Image" src="https://github.com/user-attachments/assets/4a2fe038-2882-4f92-950d-6c3aba16302c" />

<img width="1327" height="918" alt="Image" src="https://github.com/user-attachments/assets/bcc70909-83f9-4633-9e52-6023ef363b77" />

<img width="1154" height="800" alt="Image" src="https://github.com/user-attachments/assets/4b6d7aec-2083-415f-93b1-03150e5d5591" />

<img width="1835" height="907" alt="Image" src="https://github.com/user-attachments/assets/4193017a-44a9-4fb2-87da-0eed79262630" />

<img width="1871" height="894" alt="Image" src="https://github.com/user-attachments/assets/a3847096-b2ba-42da-a406-c2e262b479c4" />

<img width="1715" height="908" alt="Image" src="https://github.com/user-attachments/assets/7b1f2931-2b90-4661-b4aa-55c7eef36b32" />

<img width="1846" height="901" alt="Image" src="https://github.com/user-attachments/assets/58082a48-463c-4807-b20c-fe9bebfdbc1f" />

<img width="1834" height="877" alt="Image" src="https://github.com/user-attachments/assets/5232895e-6f92-4d85-82fe-6ec549260243" />

<img width="1837" height="904" alt="Image" src="https://github.com/user-attachments/assets/2074f666-8862-4097-a230-4b4ccf67f2b3" />

<img width="930" height="400" alt="Image" src="https://github.com/user-attachments/assets/0356fb7a-79fc-4de7-bd03-ad2023d39026" />

<img width="1882" height="879" alt="Image" src="https://github.com/user-attachments/assets/0490d960-12e0-409c-8ea8-d34b6f0b41fd" />

---

## 🏗️ Kurulum
```bash
# Projeyi klonla
git clone https://github.com/Cevdet-Karakulak/HotelierApiProject

# API katmanını aç
cd MyHotelApiProject/HotelProject.WebAPI

# Gerekli paketleri yükle
dotnet restore

# Veritabanı migration işlemleri
dotnet ef database update

# API'yi çalıştır
dotnet run
