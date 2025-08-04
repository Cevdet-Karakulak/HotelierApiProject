# 🏨✨ Kurumsal Otel Rezervasyon RESTful API Projesi ✨🏨

Bu proje, **REST prensiplerine uygun**, **tam kapsamlı bir otel rezervasyon ve yönetim sistemi** olarak geliştirilmiştir.  
Backend işlemleri tamamen **ASP.NET Core Web API** ile sağlanmış, **MVC tabanlı frontend** ile entegre edilmiştir.  

**Hedef:** Kurumsal bir otel rezervasyon sisteminin, **gerçek dünya senaryolarına** uygun şekilde N-Katmanlı mimari kullanılarak geliştirilmesi.  

---

## 🚀 Kullanılan Teknolojiler
- **ASP.NET Core 7.0 Web API**  
- **ASP.NET Core MVC (UI)**  
- **Entity Framework Core + MSSQL**  
- **Identity & JWT Authentication**  
- **AutoMapper**  
- **FluentValidation**  
- **RapidAPI Entegrasyonu**  
- **Repository Design Pattern**  
- **AJAX & ViewComponents**  
- **MailKit (SMTP) ile Mail Gönderimi**

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
> *(Buraya admin paneli, rezervasyon formu, dashboard ve otel listeleme sayfalarının ekran görüntüleri eklenecek.)*

---

## 🏗️ Kurulum
```bash
# Projeyi klonla
git clone https://github.com/kullaniciadi/MyHotelApiProject.git

# API katmanını aç
cd MyHotelApiProject/HotelProject.WebAPI

# Gerekli paketleri yükle
dotnet restore

# Veritabanı migration işlemleri
dotnet ef database update

# API'yi çalıştır
dotnet run
