using System.ComponentModel.DataAnnotations;


namespace Mission11_BookLibrary.Models
{ 
	public class Project
	{

			[Key]
			public string Title { get; set; }
			
			public string Author { get; set; }

			public string Publisher { get; set; }

			public int ISBN { get; set; }

			public string Category { get; set; }

			public int NumberOfPages { get; set; }

			public int Price { get; set; }
	
	}
}