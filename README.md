# 🍴 TasteUp-SignalR

> 🎓 Bu proje, **Murat Yücedağ** hocamızın hazırladığı Udemy de bulunan 
> **"Asp.Net Core Api SignalR ile QR Kodlu Sipariş Yönetimi"** eğitim serisi kapsamında geliştirilmiştir.

[📺 Eğitim serisine buradan ulaşabilirsiniz](https://www.udemy.com/course/aspnet-core-api-signalr-ile-qr-kodlu-siparis-yonetimi/)

---

## 📋 Proje Hakkında

Bu proje, ASP.NET Core 6.0 ve Entity Framework Core kullanılarak geliştirilmiş, çok katmanlı mimariye sahip bir restoran yönetim sistemidir. Uygulama, N-Tier Architecture ve Code First yaklaşımıyla tasarlanmış olup Microsoft SQL Server veritabanı üzerinde çalışmaktadır.

TasteUp-SignalR, hem müşteriler hem de yöneticiler için kapsamlı bir platform sunar. Müşteriler; sipariş oluşturma, rezervasyon yapma ve sepet işlemlerini gerçekleştirme gibi işlemleri kolayca yapabilirken, yöneticiler admin paneli üzerinden tüm restoran süreçlerini merkezi bir yapıdan yönetebilmektedir.

Projenin en önemli özelliklerinden biri, SignalR entegrasyonu sayesinde gerçek zamanlı veri akışı sağlamasıdır. Sipariş, rezervasyon veya kasa işlemleri gibi kritik aksiyonlar anında sisteme yansıtılır ve admin paneline bağlı tüm kullanıcılar için eş zamanlı olarak güncellenir. Bu sayede işletme sahipleri, restoranın anlık durumunu canlı olarak takip edebilir.

Bu proje, ASP.NET Core ve SignalR kullanılarak gerçek zamanlı sistemlerin nasıl geliştirilebileceğini gösteren, hem kullanıcı hem de admin tarafını kapsayan yapısıyla, gerçek hayatta karşılaşılabilecek senaryolara hazırlık sağlamak ve öğrenme amacıyla tasarlanmıştır.

---

## 🎯 Projenin Amacı

Geliştirdiğim SignalR projesi, restoran rezervasyonları ve online sipariş işlemlerini kapsamlı bir şekilde yönetir. Kullanıcılar, restorana online olarak sipariş verebilir veya rezervasyon oluşturabilirler. Sipariş vermek için kullanıcıların önce giriş yapmaları gerekmektedir. Giriş yaptıktan sonra, menüdeki yiyecek ve içecekleri seçip sepetlerine ekleyebilirler.

Siparişler ve rezervasyonlar, admin panelinde SignalR teknolojisi kullanılarak gerçek zamanlı olarak görüntülenir. Bu sayede adminler, siparişler ve rezervasyonlar üzerinde anlık olarak işlem yapabilir, onaylayabilir veya iptal edebilirler. Kullanıcılar ve adminler, herhangi bir durum değişikliğinde, ilgili e-posta adreslerine bilgilendirme alırlar. Bu özellik, tüm işlemlerin hızlı ve etkili bir şekilde takip edilmesini sağlar.

Ayrıca sistem, kasa işlemlerinden müşteri sayısına, ürün istatistiklerinden masa durumlarına kadar restoranın tüm verilerini gerçek zamanlı olarak takip eder. Admin panelinde görüntülenen bu istatistikler, işletme sahiplerinin karar verme süreçlerine destek olur ve restoran yönetimini daha verimli hale getirir.

---

## 🛠️ Kullanılan Teknolojiler

## 📌 Backend

- **ASP.NET Core 6.0**
- **ASP.NET Core Web API**
- **N-Tier Architecture**
- **Entity Framework Core** (Code First yaklaşımı)
- **MS SQL Server**
- **ASP.NET Core Identity**
- **Repository Pattern**
- **SOLID prensipleri**
- **REST API**
- **SignalR** (Gerçek zamanlı iletişim ve istatistik takibi)
- **AutoMapper**
- **FluentValidation**
- **Swagger**
- **MailKit** (E-posta gönderimi)
- **QRCoder** (QR kod oluşturma)

## 📌 Frontend

- **HTML5**
- **CSS3**
- **JavaScript**
- **Bootstrap**
- **jQuery**
- **SignalR JavaScript Client** (Gerçek zamanlı bağlantı)

---

## 📌 Katmanlar

- UI Layer
- Entity Layer
- DataAccess Layer
- Business Layer
- Dto Layer
- Web Api Layer

---

## 📌 Öne Çıkan Özellikler

- Restorana rezervasyon yapma özelliği
- Rezervsyonları detaylı bir şekilde admin panelinde yönetebilme özelliği
- MSSQL ile ilişkili tablolar
- Online sipariş verme seçeneği
- Identity
- Admin paneli
- SignalR ile canlı mesajlaşma (chatbox benzeri)
- SignalR ile masa durumlarını gerçek zamanlı görüntüleme
- Anlık istatistiklerin görüntülenmesi
- E-posta gönderme özellikleri
- Masaya özgü QR Kod ile işlem yapma

---

## 🖼️ Ekran Görüntüleri

### 🏠 Ana Sayfa

<div align="center">
  <img src="TasteUp-Images/Anasayfa-1.png" alt="Ana Sayfa-1" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-2.png" alt="Ana Sayfa-2" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-3.png" alt="Ana Sayfa-3" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-4.png" alt="Ana Sayfa-4" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-5.png" alt="Ana Sayfa-5" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-6.png" alt="Ana Sayfa-6" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-7.png" alt="Ana Sayfa-7" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-8.png" alt="Ana Sayfa-8" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-9.png" alt="Ana Sayfa-9" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-10.png" alt="Ana Sayfa-10" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-11.png" alt="Ana Sayfa-11" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Anasayfa-12.png" alt="Ana Sayfa-12" width="800" style="margin: 10px;">
 
</div>

### 🔐 Admin Paneli

<div align="center">
  <img src="TasteUp-Images/Admin-1.png" alt="Admin Paneli-1" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-2.png" alt="Admin Paneli-2" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-3.png" alt="Admin Paneli-3" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-4.png" alt="Admin Paneli-4" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-5.png" alt="Admin Paneli-5" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-6.png" alt="Admin Paneli-6" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-7.png" alt="Admin Paneli-7" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-8.png" alt="Admin Paneli-8" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-9.png" alt="Admin Paneli-9" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-10.png" alt="Admin Paneli-10" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-11.png" alt="Admin Paneli-11" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-12.png" alt="Admin Paneli-12" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-13.png" alt="Admin Paneli-13" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-14.png" alt="Admin Paneli-14" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-15.png" alt="Admin Paneli-15" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-16.png" alt="Admin Paneli-16" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-17.png" alt="Admin Paneli-17" width="800" style="margin: 10px;">
  <img src="TasteUp-Images/Admin-18.png" alt="Admin Paneli-18" width="800" style="margin: 10px;">
</div>

### 🔑 Login ve Register Sayfası

<div align="center">
  <img src="TasteUp-Images/Login.png" alt="Login Sayfası" width="600" style="margin: 10px;">
  <img src="TasteUp-Images/Register.png" alt="Register Sayfası" width="600" style="margin: 10px;">
</div>

### 🗄️ Database Diyagram

<div align="center">
  <img src="TasteUp-Images/Database.png" alt="Database Diyagram" width="1000" style="margin: 10px;">
</div>

### ⚠️ Hata Sayfası

<div align="center">
  <img src="TasteUp-Images/404.png" alt="404 Hata Sayfası" width="1000" style="margin: 10px;">
</div>
