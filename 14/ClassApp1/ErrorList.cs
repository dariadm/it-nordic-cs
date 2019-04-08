using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class ErrorList : IDisposable, IEnumerable<string>
{
	public static string OutPrefixFormat { get; set; }
	public string Category { get; private set; }
	private List<string> _errors;

	static ErrorList()
	{
		OutPrefixFormat = "yyyy-MM-ddTHH:mm:ss";
		//OutPrefixFormat = "M d, yyyy (hh:mm)";
	}

	public ErrorList(string category)
	{
		Category = category;
		_errors = new List<string>();
	}

	public void Add(string errorMessage)
	{
		_errors.Add(errorMessage);
	}

	public void WriteToConsole()
	{
		foreach (var error in _errors)
			Console.WriteLine(DateTime.Now.ToString(OutPrefixFormat) + $"	{Category}" + $"	{error}");
	}

	public void Dispose()
	{
		if (_errors != null)
		{
			_errors.Clear();
			_errors = null;
		}
	}

	public IEnumerator<string> GetEnumerator()
	{
		return _errors.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return _errors.GetEnumerator();
	}
}
