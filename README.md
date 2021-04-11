# ReCapProject
### Bu proje eğitim boyunca gelişmemi gösteren bir projedir. 2 aylık Back-end eğitimi ile projemi katmanlı mimariye ve SOLID prensiblerine uygun olarak geliştirdim. Projem de Entity Framework, Fluent Validation, AOP, OOP, Cross Cutting Concerns, WebApi, Autofac, Extensions, Authorization kısımları göreceksiniz.

# Araç Kiralama Sistemi
![banner resmi](https://github.com/alifurknaksu/ReCapProject/blob/master/WebAPI/CarImages/MercedesAmgGt-S.jpeg)


### 🔊 PROJE OLUŞTURULDU(30.01.2021)

⚪ Entities, DataAccess, Business ve Console katmanlarını oluşturuldu.

⚪ 'Car' nesnesi oluşturuldu.

⚪ Id, BrandId, ColorId, ModelYear, DailyPrice, Description özellikleri eklendi.

⚪ InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazıldı


### 🔊 GÜNCELLEME(03.02.2021)

⚪ Brand ve Color nesneleri ekleyindi.

⚪ Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturuldu.

⚪ Sisteme Generic IEntityRepository altyapısı yazıldı.

⚪ Car, Brand ve Color nesneleri için Entity Framework altyapısını yazıldı.

⚪ GetCarsByBrandId , GetCarsByColorId servislerini yazıldı ve kurallar eklendi.


### 🔊 GÜNCELLEME(06.02.2021)

⚪ Core katmanı oluşturuldu.

⚪ IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyaları eklendi.

⚪ Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getirildi.


### 🔊  GÜNCELLEME(10.02.2021)

⚪ Core katmanında Results yapılandırması oluşturuldu.

⚪ Business sınıfları bu yapıya göre refactor edildi.

⚪ Users, CUstomers ve Rentals tabloları oluşturuldu.

⚪ Entityler eklendi, CRUD operasyonları yazıldı ve test edildi.

### 🔊  GÜNCELLEME(13.02.2021)

⚪ WebApi katmanı kuruldu.

⚪ Business tarafındaki servisleri Api karşılığı yazıldı.

### 🔊  GÜNCELLEME(17.02.2021)

⚪ Autofac desteği eklendi.

⚪ FluentValiidation desteği eklendi.

⚪ AOP desteği eklendi.

⚪ ValidationAspect eklendi.

### 🔊  GÜNCELLEME(24.02.2021)

⚪ CarImages (Araba Resimleri) tablosu oluşturuldu.

⚪ Api üzerinden arabaya resim ekleyecek sistem yazıldı.

⚪ Resim silme, güncelleme yetenekleri eklendi.

### 🔊  GÜNCELLEME(28.02.2021)

⚪ JWT entegrasyonu eklendi.

### 🔊  GÜNCELLEME(01.03.2021)

⚪ Cache, Transaction ve Performance aspectlerini eklendi.

## BRANDS                                    
| BrandId      | BrandName    |                
| :---         | :---         |                
| 1            | Tesla        |                
| 2            | Porsche      | 
| 3            | Renault      |                 
| 4            | BMW          | 
| 5            | Mercedes     | 
| 6            | Volvo        | 
| 7            | Chevrolet    | 
| 8            | Ford         | 
| 9            | Wosvagen     | 
| 10           | Opel         | 

## COLORS                                   
| BrandId      | BrandName    |                
| :---         | :---         |                
| 1            | Black        |                
| 2            | White        | 
| 3            | Red          |                 
| 4            | Blue         | 
| 5            | Grey         | 
| 6            | Purple       | 
| 7            | Yellow       | 
| 8            | Green        | 
| 9            | Brown        | 
| 10           | Silver       | 






## CARS

| CarId        | CarName      | BrandId        | ColorId       |ModelYear     |DailyPrice    |Description                             |
| :---:        | :---:        |     :---:      |          :---:|         :---:|         :---:|         :---:                          |
| 1            | Model X      | 1              | 2             | 2018         | 1000,0000    | 4 Koltuk ,Otomatik, Elektrikli, Otonom |
| 2            | Cayenne      | 2              | 1             | 2020         | 1400,0000    | 4 Koltuk, Otomatik,Benzinli            |
| 3            | Kadjar       | 3              | 5             | 2020         | 750,0000     | 4 Koltuk,  Otomatik,  Benzinli         |
| 4            | AMG Gt-S     | 5              | 7             | 2020         | 1250,0000    | 2 Koltuk, Otomatik, Benzinli           |
| 5            | Corvette C8  | 7              | 1             | 2020         | 1400,0000    | 2 Koltuk, Otomatik, Benzinli           |
| 6            | Cayman       | 2              | 1             | 2020         | 1100,0000    | 4 Koltuk, Otomatik, Benzinli           |



 








