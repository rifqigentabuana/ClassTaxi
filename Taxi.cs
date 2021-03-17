using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TugasClass

{
	public class Taxi
	{
		// properties
		public string Status { get; set; }
		public string Status2 { get; set; }
		public string Nama { get; set; }
		public string Nama2 { get; set; }
		public int Jml_Penumpang { get; set; }
		public int Jml_Penumpang1 { get; set; }

		// method
		// note. disini saya asumsi-kan "penurunan penumpang" = tendang keluar dari taxi karena hal-hal tertentu
		public void Info_Driver()
		{
			Console.WriteLine("\nTAXI ONLINE DABEST");
			Console.WriteLine("Nama: {0}", Nama);
			Console.WriteLine("Status: {0}", Status);
			Console.WriteLine("Total Penumpang Hari Ini: {0}", Jml_Penumpang);

		}
		public void Status_Driver()
		{ 
			Console.WriteLine("{0}\n", Status);
			Console.WriteLine("Total Jumlah Pengambilan Penumpang :{0}\n", Jml_Penumpang);
			Console.WriteLine("Total Jumlah Penurunan Penumpang :{0}\n", Jml_Penumpang1);
		}
		public void Info_Driver2()
		{
			Console.WriteLine("\nTAXI ONLINE DABEST");
			Console.WriteLine("Nama: {0}", Nama);
			Console.WriteLine("Status: {0}", Status2);
			Console.WriteLine("Total Penumpang Hari Ini: {0}", Jml_Penumpang);

		}
		public void Status_Driver2()
		{
			Console.WriteLine("{0}\n", Status2);
			Console.WriteLine("Total Jumlah Pengambilan Penumpang :{0}\n", Jml_Penumpang);
			Console.WriteLine("Total Jumlah Penurunan Penumpang :{0}\n", Jml_Penumpang1);
		}
	}
}