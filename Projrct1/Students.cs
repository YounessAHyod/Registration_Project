using System;

internal class Students
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string FatherName { get; set; }
    public DateTime DateofBirth { get; set; }
    public DateTime JoinDate { get; set; }
    public string Nationality { get; set; }

    public Students(string name, string lastName, string fatherName, DateTime dateofBirth, DateTime joinDate, string nationality)
    {
        
        if (string.IsNullOrEmpty(name))

        {
            throw new ArgumentException("Please Enter Name.");

        }

        

        Name = name;

        LastName = lastName;

        FatherName = fatherName;

        DateofBirth = dateofBirth;

        JoinDate = joinDate;

        Nationality = nationality;

    }
}
