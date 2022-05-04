using MyFirstClass;

var evan = new MyFirstClass.TQLStudent("Evan", "Mercurio",5);
var evangit = new Assessment() {
    Topic = "Git/GitHub",
    Points = 110,
    Taken = DateTime.Now
    };
evan.GitHubAssessment = evangit;

evan.HappyAnniversary();
Console.WriteLine(evan.Print());

var sarah = new MyFirstClass.TQLStudent("Sarah", "Wainscott",0);
var sarahgit = new Assessment() {
    Topic = "Git/GitHub",
    Points = 110,
    Taken = DateTime.Now
    };
var sarahsql = new Assessment() {
   Topic = "SQL",
   Points = 110,
   Taken= DateTime.Now
    };
var sarahcsharp = new Assessment() {
    Topic = "C#",
    Points = 110,
    Taken = DateTime.Now
    };
var sarahjavascript = new Assessment() {
    Topic = "Javascript",
    Points = 110,
    Taken = DateTime.Now
    }; 
var sarahang = new Assessment() {
    Topic = "Angular",
    Points = 110,
    Taken = DateTime.Now
        };
sarah.GitHubAssessment = sarahgit; //matches my scores assigned in sarahgit to property assessment which is a property of the class of student
sarah.SQLAssessment = sarahsql;
sarah.CSharpAssessment = sarahcsharp;
sarah.JavascriptAssessment= sarahjavascript;
sarah.AngularAssessment = sarahang;
Console.WriteLine(sarah.Print());


var git = new Assessment() { Topic = "Git/GitHub", Points = 110, Taken = DateTime.Now };
var test = new TQLStudent() {
    FirstName = "Test",
    YearsOfService = 99,
    GitHubAssessment = git
    };
Console.WriteLine(test.Print());


