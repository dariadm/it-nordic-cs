using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//BaseDocument firstDocument = new BaseDocument
			//{
			//	DocName = "Driving License",
			//	DocNumber = "0234242",
			//	IssueDate = DateTimeOffset.Parse("02 - 02 - 2015")
			//};

			//Passport secondDocument = new Passport
			//{
			//	DocName = "Passport",
			//	DocNumber = "0342325",
			//	IssueDate = DateTimeOffset.Parse("02 - 01 - 2012"),
			//	Country = "Russia",
			//	PersonName = "Daria"
			//};

			//BaseDocument firstDocument = new BaseDocument("Driving License", "0234242", DateTimeOffset.Parse("02 - 02 - 2015"));
			//Passport secondDocument = new Passport("0342325", DateTimeOffset.Parse("02 - 01 - 2012"), "Russia", "Daria");
			//Passport thirdDocument = new Passport(firstDocument, "USA", "Volkova");

			//firstDocument.WriteToConsole();
			//secondDocument.WriteToConsole();
			//thirdDocument.WriteToConsole();

			var myDocuments = new BaseDocument[4];
			myDocuments[0] = new BaseDocument("Driving License", "0234242", DateTimeOffset.Parse("02 - 02 - 2015"));
			myDocuments[1] = new Passport("0342325", DateTimeOffset.Parse("02 - 01 - 2012"), "Russia", "Daria");
			myDocuments[2] = new BaseDocument("Diploma", "03242325", DateTimeOffset.Parse("02 - 02 - 2010"));
			myDocuments[3] = new Passport("28394239489", DateTimeOffset.Parse("03 - 01 - 2008"), "Russia", "Daria");

			foreach (var document in myDocuments)
			{
				if (document is Passport)
				{
					Passport newDocument = (Passport)document;
					newDocument.ChangeIssueDate(DateTimeOffset.Parse("01 - 04 - 2019"));
				}

				document.WriteToConsole();
			}
		}
	}
}
