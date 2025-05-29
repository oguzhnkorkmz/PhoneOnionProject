📱 PhoneOnionProject
PhoneOnionProject, telefon satışına yönelik geliştirilen bir web uygulamasıdır. Proje, temiz mimari prensiplerine uygun olarak katmanlı bir yapı ile geliştirilmiştir ve ASP.NET Core MVC kullanılarak oluşturulmuştur.

🧱 Proje Mimarisi

Proje, aşağıdaki katmanlardan oluşmaktadır:
Onion.CoreLayer: Temel domain modelleri ve arayüzleri içerir.
Onion.ApplicationLayer: Uygulama servisleri ve iş mantığı bu katmanda yer alır.
Onion.InfrastructureLayer: Veri erişimi ve dış servis entegrasyonları bu katmanda bulunur.
Onion.UI.MVC_Core: Kullanıcı arayüzü ve MVC yapısı bu katmanda geliştirilmiştir.

Bu yapı, SOLID prensiplerine uygun, sürdürülebilir ve test edilebilir bir mimari sunar.

🚀 Başlarken

Projeyi çalıştırmak için aşağıdaki adımları izleyebilirsiniz:
Projeyi Klonlayın:
git clone https://github.com/oguzhnkorkmz/PhoneOnionProject.git
cd PhoneOnionProject
Gerekli Bağımlılıkları Yükleyin:

Veritabanını Oluşturun:
Onion.InfrastructureLayer katmanında yer alan DbContext sınıfını kullanarak veritabanını oluşturun. Gerekli migrasyonları uygulayın:

dotnet ef migrations add InitialCreate
dotnet ef database update
Projeyi Çalıştırın:

Onion.UI.MVC_Core projesini başlangıç projesi olarak ayarlayın ve uygulamayı çalıştırın.

📂 Katmanlar ve Sorumlulukları

CoreLayer: Domain modelleri ve repository arayüzlerini içerir.
ApplicationLayer: Uygulama servisleri ve iş kurallarını barındırır.
InfrastructureLayer: Entity Framework Core kullanılarak veri erişimi sağlanır.
UI.MVC_Core: Razor view'lar ve controller'lar ile kullanıcı arayüzü sunulur.

🛠️ Kullanılan Teknolojiler

ASP.NET Core MVC
Entity Framework Core
C#
HTML, CSS, JavaScript
