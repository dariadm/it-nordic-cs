using System;
using System.Collections.Generic;
using System.Text;

class PersonalInfo
{
    public string Name { get; set; }
    public byte Age { get; set; }

    public byte AgeInFourYears
    {
        get
        {
            return (byte)(Age + 4);
        }
    }
    public string PersonalInfoString
    {
        get
        {
            return $"Name: {Name}, age in 4 years: {AgeInFourYears}";
        }
    }
}


