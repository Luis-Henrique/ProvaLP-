namespace Avaliacao3BimLp3.Models;

public class CountStudentGroupAttribute
{
    public string AttributeName { get; set; }
    public int StudentNumber { get; set; }

    public CountStudentGroupAttribute()
    { 

    }

    public CountStudentGroupAttribute(string attributeName, int studentNumber)
    {
        AttributeName = attributeName;
        StudentNumber = studentNumber;
    }
}
