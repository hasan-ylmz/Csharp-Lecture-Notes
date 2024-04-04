using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_clean_Code_1
{
    internal class Program
    {
        public class Customer
        {
            public string Name { get; set; }

            public string LastName { get; set; }

            public bool OgrencıMI { get; set; }

            public string OdemeTuru { get; set; }

            public double Fıyat { get; set; }


            private const double    DolarKuru= 37;
            private const double  EuroKuru = 32;

            public void OgrencıFıyat(Customer customer)
            {

                if (OgrencıMI)
                {
                    Fıyat = Fıyat - (Fıyat * .10);
                    Console.WriteLine($"{Name} {LastName} adlı kişinin ödeyeceği : " + Fıyat);
                }
                else if (OdemeTuru == "Dolar") 
                {
                    Fıyat = Fıyat /  DolarKuru;   
                }
                else if(OdemeTuru == "Euro")
                {
                    Fıyat = Fıyat / EuroKuru;
                }
                else
                {
                    Console.WriteLine(Fıyat);
                }
            }

            public void CustomerInfo()
            {
                Console.WriteLine($"{Name} {LastName} {Fıyat}");
            }

        }


        /*
        
        *** Clean Code Temiz Kod Yazma Sanatı ***
        
        Kervan yolda düzülür mantığı yanlıştır. Later equals never
        Müşteri taleplerini sürekli sunar . 
        
        SONARCUBE = Yazdığınız kodun temiz olup olmadığını gösterecek .Solıd ve diğer metodolojilere bakıyor.

        Çalışıyorsa dokunma mantığı yanlıştır .

        Önemli olan sonuca ulaşmaktır. Kimse nasıl yaptığınızı sorgulamaz .
        Bu yanlış bir düşüncedir. Müşteri sadece önyüzü görüyor .

        Arka plan ile zaten ilgilenmiyor deyip önemsemezsek ileride herhangi bir değişiklikte 
        program buna direnç gösterir. 


        _________________________________________________________________
        
        1) İsimlendirme Kuralları 

        Yanlış kullanım  int s;
        Doğru kullanım   int sayı;
        
        Değişken ismi tekrar hatırlanabilir ve okununca anlaşılabilir olmalı .Uzun yazmaktan çekinmeyin.
        Değişken ismine bakılınca aslında kendini açıklayabilmeli .


        İsimlendirmede dikkat edilmesi gereken diğer bir husus da metod isimlendirmesidir .
        Aşağıdaki kodda TumunuListele adlı bir metodumuz var lakin bu metdo neyin tümünü listelemektedir .
        Bunu bilmiyoruz .Burası tam açıklayıcılık konusundan uzaktır .


        Yanlış kullanım public List<string[]> TumunuListele() {}
        Doğru  kullanım public List<string[]> KullanıcıAdınınTumunuListele() {}


        Engin hocanın notu :Common Language 
        It süreçlerinde common language kullan . Kısaca değişkenlere verdiğiniz isim standartları ,
        metodları yapılandırma şeklinizde herkes aynı davranmalı .Kişiler isimlendirme yaparken 
        farklı davranmamalı . Ortak bir dil kullan .


        Dil kullanım koşulları nelerdir  ? Her dilin farklı kuralları vardır . (bkz .C# naming conventions , JS naming conventions)

        İsimlendirirken biraz düşünmek iyidir . Daha sonra düzeltirim demek doğru bir yaklaşım değildir .
        Aşırı tasarıma kaçmadan buna dikkat etmek gerekir . 


        2) Fonksiyonlar 
        Yanlış kullanım 
        public class Customer
            {
                public string Name { get; set; }
                public string Email { get; set; }
                public decimal Balance { get; set; }

                public Customer(string name, string email)
                {
                    Name = name;
                    Email = email;
                    Balance = 0;
                }

                public void ProcessOrder(string orderDetails)
                {
                    // Siparişin işlenmesiyle ilgili kodlar
                    Console.WriteLine($"Processing order for {Name}: {orderDetails}");
                }

                public void SendEmailConfirmation()
                {
                    // E-posta onayının gönderilmesiyle ilgili kodlar
                    Console.WriteLine($"Sending email confirmation to {Email}");
                }

                public void UpdateBalance(decimal amount)
                {
                    // Bakiye güncelleme işlemleriyle ilgili kodlar
                    Balance += amount;
                    Console.WriteLine($"Balance updated for {Name}. New balance: {Balance}");
                }
            }

            // Kullanım örneği
            class Program
            {
                static void Main()
                {
                    Customer customer = new Customer("John Doe", "john.doe@example.com");

                    // Customer sınıfı hem sipariş işleme hem de e-posta gönderme işlevselliğini içeriyor
                    customer.ProcessOrder("New order");
                    customer.SendEmailConfirmation();
                    customer.UpdateBalance(100);
                }



        Doğru kullanım 
        
            // Customer sınıfı sadece müşteri bilgilerini içerir
            public class Customer
            {
                public string Name { get; set; }
                public string Email { get; set; }

                public Customer(string name, string email)
                {
                    Name = name;
                    Email = email;
                }
            }

            // OrderProcessor sınıfı sipariş işleme işlevselliğini içerir
            public class OrderProcessor
            {
                public void ProcessOrder(Customer customer, string orderDetails)
                {
                    // Siparişin işlenmesiyle ilgili kodlar
                    Console.WriteLine($"Processing order for {customer.Name}: {orderDetails}");
                }
            }

            // EmailSender sınıfı e-posta gönderme işlevselliğini içerir
            public class EmailSender
            {
                public void SendEmailConfirmation(Customer customer)
                {
                    // E-posta onayının gönderilmesiyle ilgili kodlar
                    Console.WriteLine($"Sending email confirmation to {customer.Email}");
                }
            }

            // Kullanım örneği
            class Program
            {
                static void Main()
                {
                    Customer customer = new Customer("John Doe", "john.doe@example.com");

                    OrderProcessor orderProcessor = new OrderProcessor();
                    orderProcessor.ProcessOrder(customer, "New order");

                    EmailSender emailSender = new EmailSender();
                    emailSender.SendEmailConfirmation(customer);
                }
            }

        Fonskiyon ve class yazarken Single Responsibility prensibine bakılarak yazılır .
        Ne demek Sİngle of Responsibility ? 
        Class veya fonksiyon sadece bir işi yapabilir . Nesnel dili fonksiyonel bir dil gibi kullanamazsın 
        O zaman zaafiyet yaşarsın .


        BKZ . 
        ( Engin hocanın notu : Single of responsibility (SOLID ) Refactoring Tools ,

        Google Search Example : Single of responsibility principle , Code refactoring  )

        Kodu sadece if else içinde farklı parçalara bölüp her işi bir fonskiyona aktarırsak kodun 
        okunabilirliği daha kolay olur . 
        

        Diyelim ki x işi birkaç tane if else bloğu içinde olmuş olsun .Daha sonra x işine tek olarak ihtiyacımız var
        Kodu tek olarak çağırmak istediğimizde işlemi yapamıyoruz . Çözümü kodu refactor etmektir .

        Daha sonra bu kodu değiştirmemiz gerektiğinde kullandığımız x kadar yerde değiştirme veya 
        kodu yeniden yapılandırmamız gerekiyor. X-2 kadar blok yeniden düzenlendi .
        Ancak geriye kalan 2 blok düzeltilmedi . Bu başımıza problem açabilir .
        
        
        3) Yorumlar 


        public abstract class ContainerBase implements Container, Lifecycle, Pipeline , MBeanRegistration


        // The processor delay for this component
        protected int backgroundProcessorDelay = -1;


        // The lifecycle event support for this component.
        protected LifecycleSupport lifecycle = new LifecycleSupporter(this);

        // The container event listeners for this Container .
        protected ArrayList listeners = new ArrayList();


        Engin hocanın notu : Kurumsal hafıza için yapılıyor fakat yanlış yerde yapılıyor .
        Software Development Methodolgy (Agile), ALM 

        Google Search Example : SCRUM with TFS 

        
        Fonskiyonun içine comment yazılmaz .Fonskiyonun içindeki işleri yapan kodlar için comment yazılması doğru değildir.
        Yazılan fonksiyonun temiz görünmesi gerekiyor .
        Fonksiyonun desteği amaçlı üzerinde yazılabilir . Lakin içine yazılmaz . Dokümantasyon için yazarken comment oranına dikkat etmek gerekir


        4) Soyutlama 

        Çıplak class kalmasın 
        Eğer bir classınız bir baseden bir interfaceden abstract bir baseden  superclass olan bir baseden beslenmiyor.
        Class musterı:verı   class musterı:Dal gibi sadece class ismi barındıyorsa soyutlama yoksa değişime direnç gösteren bir sistemle karşı karşıyasınız .
         
        Temiz kodun olmazsa olmazlarından biri soyutlamadır .


        5) SOLID
        Kodu SOLID yaparsanız , geliştirme çok daha rahat olacaktır. 


        6) Aspect Oriented Programming 

        [FluentValidationAspect(typeof(ProductValidator))] -> Validasyon kodları 
        [TransActionScopeAspect] -> Transaction kodları 
        [CacheRemoveAspect] -> Cache kodları 
        [LogAspect(typeof(DatabaseLogger))] -> Loglama kodları  
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        Eğer bir alanda sadece şart blokları kullanmış olsaydı çok daha fazla iş yapmamız gerekecekti 
        
        Metodun kendisi, işlevsel gereksinimleri temsil eder ve _productDal.Add(product) şeklinde bir ürün eklemeye odaklanır. 
        Ancak, bu metodun çalışması sırasında doğrulama, işlem, önbellek ve loglama gibi yatay konulara ilişkin işlemler, 
        bu aspect'ler aracılığıyla ayrı sınıflar ve kurallar tarafından yönetilir. Aspect'ler, kod içinde tekrar 
        eden ve genel olarak geçerli olan bu yatay konuları merkezi bir şekilde ele almayı sağlar, 
        bu da kodun temiz ve modüler olmasına olanak tanır.
        

        Clean Code OOP  project demo 

        GEREKSINIMLER
        -> Kullanıcı bir ürünü satın almak istiyor. 
        -> Ürünün fiyatı öğrencilere %10 indirimli olarak yansıtacaktır .
        -> Default olarak Tl ödeme yapacaktır.
        -> Ürün fiyatını isterse Dolar veya Euro ödeyebilirler
        -> Döviz karşılığı merkez bankası servisi tarafından alınacaktır.

        Data: 
        Ürün: Televizyon /1000 TL
        Normal bir müşteri / TL 

        Çıktı:
        Engin Demiroğ ürünü satın aldı . 1000 Tl ödeme yaptı .



        Data: 
        Ürün : Televizyon/1000 TL
        Öğrenci / TL 
        
        Çıktı: 
        Tahir Çalışkan ürünü satın aldı .900 tl ödeme alındı . 



        Data : 
        Ürün : Televizyon /1000 TL 
        Öğrenci / Dolar 
        Çıktı: 
        Engin Demiroğ ürünü satın aldı . 170 dolar ödeme alındı .

        */



        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Name = "Engin",
                LastName = "Demiroğ ",
                OgrencıMI = false,
                OdemeTuru = "Euro",
                Fıyat=900,

            };
            
            Customer customer1 = new Customer()
            {
                Name = "Hasan",
                LastName = "Yılmaz",
                OgrencıMI = false,
                Fıyat = 310,
                OdemeTuru="Euro",
            };

            Customer customer2 = new Customer()
            {
                Name =" Emre ",
                LastName ="bahcecı",
                OgrencıMI=true ,
                Fıyat =5000,

            };

            Customer customer3 = new Customer()
            {
                Name ="Mehmet",
                LastName ="Zorlu",
                OgrencıMI =false,
                OdemeTuru ="Dolar",
                Fıyat = 10000,
                
            };

            customer.OgrencıFıyat(customer);
            customer.CustomerInfo();

            customer1.OgrencıFıyat(customer1);
            customer1.CustomerInfo();

            customer2.OgrencıFıyat(customer2);
            customer2.CustomerInfo();

            customer3.OgrencıFıyat(customer3);
            customer3.CustomerInfo();

            // Mission İmpossible finished 
        }
    }
}
