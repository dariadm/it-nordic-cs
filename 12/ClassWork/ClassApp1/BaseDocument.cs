using System;
using System.Collections.Generic;
using System.Text;

class BaseDocument
{
	public string DocName { get; set; }
	public string DocNumber { get; set; }
	public DateTimeOffset IssueDate { get; set; }

	virtual public string PropertiesString
	{
		get
		{
			return $"DocName: {DocName}, DocNumber: {DocNumber}, IssueDate: {IssueDate}";
		}
	}

	public BaseDocument(string docName, string docNumber, DateTimeOffset issueDate)
	{
		DocName = docName;
		DocNumber = docNumber;
		IssueDate = issueDate;
	}

	virtual public void WriteToConsole()
	{
		Console.WriteLine(PropertiesString);
	}
}



