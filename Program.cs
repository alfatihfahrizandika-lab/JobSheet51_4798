Console.WriteLine("=== CETAK DOKUMEN ===");
Console.WriteLine("Nama pelanggan = Fatih");
string namaPelanggan = Console.ReadLine();
Console.WriteLine("Jumlah halaman = 30");
int jumlahHalaman = int.Parse(Console.ReadLine());
Console.WriteLine("Harga per halaman = 400 ");
int hargaPerHalaman = int.Parse(Console.ReadLine());
Console.WriteLine("Biaya administrasi = 2000");
int biayaAdministrasi = int.Parse(Console.ReadLine());
int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdministrasi;
 Console.WriteLine("\n=== CETAK DOKUMEN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Jumlah halaman = {jumlahHalaman}");
Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {subtotal}");
Console.WriteLine($"Total bayar = {totalBayar}");

