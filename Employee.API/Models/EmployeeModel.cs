namespace User.API.Models;

public class EmployeeModel
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public decimal Salary { get; set; }

    public static IEnumerable<EmployeeModel> Employees = new List<EmployeeModel>
    {
        new EmployeeModel
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Salary = 50000
        },
        new EmployeeModel
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith",
            Email = "jane.smith@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 3,
            FirstName = "David",
            LastName = "Johnson",
            Email = "david.johnson@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 4,
            FirstName = "Sarah",
            LastName = "Brown",
            Email = "sarah.brown@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 5,
            FirstName = "Michael",
            LastName = "Davis",
            Email = "michael.davis@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 6,
            FirstName = "Emily",
            LastName = "Wilson",
            Email = "emily.wilson@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 7,
            FirstName = "Daniel",
            LastName = "Taylor",
            Email = "daniel.taylor@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 8,
            FirstName = "Olivia",
            LastName = "Anderson",
            Email = "olivia.anderson@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 9,
            FirstName = "Matthew",
            LastName = "Thomas",
            Email = "matthew.thomas@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 10,
            FirstName = "Emma",
            LastName = "Martinez",
            Email = "emma.martinez@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 11,
            FirstName = "Christopher",
            LastName = "Garcia",
            Email = "christopher.garcia@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 12,
            FirstName = "Ava",
            LastName = "Lopez",
            Email = "ava.lopez@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 13,
            FirstName = "Andrew",
            LastName = "Hernandez",
            Email = "andrew.hernandez@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 14,
            FirstName = "Isabella",
            LastName = "Martinez",
            Email = "isabella.martinez@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 15,
            FirstName = "Ethan",
            LastName = "Clark",
            Email = "ethan.clark@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 16,
            FirstName = "Sophia",
            LastName = "Lee",
            Email = "sophia.lee@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 17,
            FirstName = "William",
            LastName = "Walker",
            Email = "william.walker@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 18,
            FirstName = "Mia",
            LastName = "Hall",
            Email = "mia.hall@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 19,
            FirstName = "Alexander",
            LastName = "Young",
            Email = "alexander.young@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 20,
            FirstName = "Charlotte",
            LastName = "Gonzalez",
            Email = "charlotte.gonzalez@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 21,
            FirstName = "James",
            LastName = "Harris",
            Email = "james.harris@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 22,
            FirstName = "Amelia",
            LastName = "Lewis",
            Email = "amelia.lewis@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 23,
            FirstName = "Benjamin",
            LastName = "Walker",
            Email = "benjamin.walker@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 24,
            FirstName = "Lily",
            LastName = "Green",
            Email = "lily.green@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 25,
            FirstName = "Henry",
            LastName = "Baker",
            Email = "henry.baker@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 26,
            FirstName = "Grace",
            LastName = "Gonzalez",
            Email = "grace.gonzalez@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 27,
            FirstName = "Daniel",
            LastName = "Walker",
            Email = "daniel.walker@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 28,
            FirstName = "Chloe",
            LastName = "Collins",
            Email = "chloe.collins@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 29,
            FirstName = "Matthew",
            LastName = "Mitchell",
            Email = "matthew.mitchell@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 30,
            FirstName = "Zoe",
            LastName = "Adams",
            Email = "zoe.adams@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 31,
            FirstName = "David",
            LastName = "Wilson",
            Email = "david.wilson@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 32,
            FirstName = "Sophie",
            LastName = "Cook",
            Email = "sophie.cook@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 33,
            FirstName = "Joseph",
            LastName = "Roberts",
            Email = "joseph.roberts@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 34,
            FirstName = "Avery",
            LastName = "Richardson",
            Email = "avery.richardson@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 35,
            FirstName = "Samuel",
            LastName = "White",
            Email = "samuel.white@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 36,
            FirstName = "Madison",
            LastName = "Hill",
            Email = "madison.hill@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 37,
            FirstName = "Benjamin",
            LastName = "Anderson",
            Email = "benjamin.anderson@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 38,
            FirstName = "Mila",
            LastName = "Carter",
            Email = "mila.carter@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 39,
            FirstName = "Jackson",
            LastName = "Garcia",
            Email = "jackson.garcia@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 40,
            FirstName = "Harper",
            LastName = "Phillips",
            Email = "harper.phillips@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 41,
            FirstName = "Henry",
            LastName = "Morris",
            Email = "henry.morris@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 42,
            FirstName = "Ella",
            LastName = "Parker",
            Email = "ella.parker@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 43,
            FirstName = "Anthony",
            LastName = "Stewart",
            Email = "anthony.stewart@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 44,
            FirstName = "Scarlett",
            LastName = "Bell",
            Email = "scarlett.bell@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 45,
            FirstName = "Sebastian",
            LastName = "Turner",
            Email = "sebastian.turner@example.com",
            Salary = 70000
        },
        new EmployeeModel
        {
            Id = 46,
            FirstName = "Victoria",
            LastName = "Perez",
            Email = "victoria.perez@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 47,
            FirstName = "Leo",
            LastName = "Gomez",
            Email = "leo.gomez@example.com",
            Salary = 60000
        },
        new EmployeeModel
        {
            Id = 48,
            FirstName = "Penelope",
            LastName = "Flores",
            Email = "penelope.flores@example.com",
            Salary = 55000
        },
        new EmployeeModel
        {
            Id = 49,
            FirstName = "Julian",
            LastName = "Rossi",
            Email = "julian.rossi@example.com",
            Salary = 65000
        },
        new EmployeeModel
        {
            Id = 50,
            FirstName = "Layla",
            LastName = "Wright",
            Email = "layla.wright@example.com",
            Salary = 70000
        }
    };
}