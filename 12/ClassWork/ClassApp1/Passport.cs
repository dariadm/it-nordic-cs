using System;
using System.Collections.Generic;
using System.Text;

class Passport : BaseDocument
{
	public string Country { get; set; }
	public string PersonName { get; set; }

	override public string PropertiesString
	{
		get
		{
			return $"DocName: {DocName}, DocNumber: {DocNumber}, IssueDate: {IssueDate}, Country: {Country}, PersonName: {PersonName}";
		}
	}

	public Passport(string docNumber, DateTimeOffset issueDate, string country, string personName) 
		: base("Passport", docNumber, issueDate)
	{
		Country = country;
		PersonName = personName;
	}

	public Passport(BaseDocument baseDocument, string country, string personName)
		:base(baseDocument.DocName, baseDocument.DocNumber, baseDocument.IssueDate)
	{
		Country = country;
		PersonName = personName;
	}

	public Passport(BaseDocument baseDocument)
	: base(baseDocument.DocName, baseDocument.DocNumber, baseDocument.IssueDate)
	{
	}

	public void ChangeIssueDate(DateTimeOffset newIssueDate)
	{
		IssueDate = newIssueDate;
	}
}

