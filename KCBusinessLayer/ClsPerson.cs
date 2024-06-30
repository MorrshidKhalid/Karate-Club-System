using KCBusinessLayer;
using KCDataAccessLayer;
public abstract class ClsPerson
{

    protected Mode mode = Mode.Add;


    public int PersonID { get; set; }
    public string FirstName { set; get; }
    public string MidName { set; get; }
    public string LastName { set; get; }    
    public string Address { set; get; }


    // Defualt constructor.
    public ClsPerson()
    {
        PersonID = 0;
        FirstName = string.Empty;
        MidName = string.Empty;
        LastName = string.Empty;
        Address = string.Empty;

        mode = Mode.Add;
    }


    // Constructor used to add (Person) Object to Database.
    protected ClsPerson
        (
        int personID,
        string firstName, string midName, string lastName, string address
        )
    {
        PersonID = personID;
        FirstName = firstName;
        MidName = midName;
        LastName = lastName;
        Address = address;

        mode = Mode.Update;
    }


    protected bool AddPerson()
    {
        int insertedID = 0;
        if (ClsKCDatabase.AddNewPersonToDB(FirstName, MidName, LastName, Address, ref insertedID))
        {
            PersonID = insertedID;
            return true;
        }

        return false;
    }
    protected abstract bool Update();
    public abstract bool Save();
    public string FullName() => $"{FirstName} {MidName} {LastName}";
}