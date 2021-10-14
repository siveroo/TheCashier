# College Assignment - The Cashier
Aplikasi ini berfungsi untuk menghitung total belanja pengguna.

## Scope & Functionalities
- User dapat memasukkan nama item, harga, kuantitas, dan tipe barang
- User dapat menambahkan item untuk dihitung total harganya
- User mendapat info tentang harga total semua itemnya

## Cara Kerja?

Pada `MainWindow.xaml.cs` kita menginisialisasi object `calculator` dan menghubungkan `listBox` dengan `calculator`

```csharp
    public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox.ItemsSource = calculator.getListItem();
        }
```


Kode dibawah berfungsi untuk menghubungkan menu dengan daftar barang dan logika perhitungan total harga, kemudian merefresh menunya
```csharp
private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = itemNameBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            Item item = new Item(new Random().Next(), title, quantity, type, price);
            calculator.addItem(item);
            double total = calculator.getTotal();

            totalLabel.Content = String.Format("Rp. {0}", total);

            listBox.Items.Refresh();
        }
```
Deklarasi class/object `User`
```csharp
class User
    {
        public String name;
        public int age;
    }  
}
```
Deklarasi class/object `Item`, dengan method untuk mendapatkan nama item, kuantitas, tipe barang, harga, dan subtotal
```csharp
 class Item
    {
        private int id;
        public string title { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;
        public Item(int _id, string _title, int _quantity, string _type, double _price)
        {
            id = _id;
            title = _title;
            quantity = _quantity;
            type = _type;
            price = _price;
            subtotal = 0;
        }

        public string getTitle()
        {
            return title;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public string getType()
        {
            return type;
        }

        public double getPrice()
        {
            return price;
        }

        public double getSubTotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
    }
```
Deklarasi class/object `Calculator`, dengan method untuk menambahkan barang, mengetahui total harga, serta mengambil `List` barang
```csharp
    class Calculator
    {
        private List<Item> listItem;
        private double total = 0;

        public Calculator()
        {
            this.listItem = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.listItem.Add(item);
            this.total += item.getSubTotal();
        }

        public double getTotal()
        {
            return total;
        }

        public List<Item> getListItem()
        {
            return listItem;
        }
    }
```

Deklarasi class `UserValidation`, untuk validasi `User` dengan method untuk mengecek apakah usia user lebih dari 17 tahun
```csharp
    class UserValidation
    {
        private User user;
        public UserValidation(User _user)
        {
            this.user = _user;
        }

        public bool isAgeAllowed()
        {
            return this.user.age > 17;
        }
    }
```
