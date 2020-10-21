# The Cashier
Aplikasi ini berfungsi untuk menghitung jumlah barang dan total barang, sehingga memudahkan user untuk menghitung dan mentotalkan jumlah barang yang di beli.

## Functionalities
- user dapat meginputkan barang
- user user dapat mentotalkan jumlah barang

## Penjelasan Code
dimulai dari MainWindows.Xaml.cs dengan source code sepreti berikut :
public Mainwindow()

'''
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox.ItemsSource = calculator.getListItem();
        }

        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            string title = itemNameBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            Item item = new Item(new Random().Next(), title, quantity, price, price, type);
            calculator.addItem(item);
            double total = calculator.getTotal();

            totalLabel.Content = string.Format("Rp. {0}", total);

            listBox.Items.Refresh();
        }

Setelah itu tambahkan class dengan nama Item.cs dengan source code seperti berikut :

public string gettitle()
        {
            return title;
        }

        public int getquantity()
        {
            return quantity;
        }

        public string gettype()
        {
            return type;
        }

        public double getprice()
        {
            return price;
        }

        public double getsubtotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }


Setelah tambahkan Item.cs tambahkan lagi class dengan nama calculator.Cs sebagai penghitung harga dengan source code seperti berikut :

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
            this.total += item.getsubtotal();
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
Prinsip Single Responsibility dapat di temukan pada source code seperti berikut :
public void addItem(item item)

    {
        this.listItem.Add(item);
        this.total += item.getSubTotal();
    }
Yang bertujuan untuk menambhakan item dan menghitung SubTotal.