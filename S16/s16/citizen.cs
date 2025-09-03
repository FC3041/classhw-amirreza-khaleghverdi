class Citizen 
{
    public string FirstName {get;set;}
    public string LastName { get; set; }
    public int NationalId { get; set; }   
    public bool ISmale { get; set; }
    public Citizen (string fname,string lname,int nID,bool Ismale)
    {
        this.FirstName=fname;
        this.LastName=lname;
        this.NationalId=nID;
        this.ISmale=ISmale;
    }
    public Citizen(){}
}

class Student:Citizen
{
    public Student (string fname,string lname,int nID,bool Ismale):base(fname,lname,nID,Ismale)
}