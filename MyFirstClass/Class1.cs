using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass {
    internal class TQLStudent {
        private static int NextId = 1; //every new instance will use this to increment id, so set to static so it increments for each new instance of student
        public int Id { get; set; } = 0; //like primary key, unqiue
        public string FirstName { get; set; } = string.Empty; 
        public string LastName { get; set; } = string.Empty;
        public int YearsOfService { get; set; } = 0;
        public Assessment? GitHubAssessment { get; set; } = null; //? allows setting default value to null
        public Assessment? SQLAssessment { get; set; } = null;  
        public Assessment? CSharpAssessment { get; set; } = null;
        public Assessment? JavascriptAssessment { get; set; } = null;
        public Assessment? AngularAssessment { get; set; } = null;
//end of properties
        public string FullName() {
            return $"{this.FirstName} {this.LastName}";
            }
        public string Print() {
            var msg = $"{Id}: {FullName()} has {YearsOfService} year{(YearsOfService != 1 ? "s" : "")} of service at TQL."; //includes ternary statement to make year plural
            if (GitHubAssessment is not null) { //only adds this line if assessment score is not null, so if student hasn't taken score won't cause error
                msg = msg + $"\n    {GitHubAssessment!.Topic} assessment points: {GitHubAssessment!.Points}. Taken: {GitHubAssessment!.Taken}."; //the slash n puts second string on second line of code. !after property means will not be null
                }
            if (SQLAssessment is not null) {
                msg = msg + $"\n    {SQLAssessment!.Topic} assessment points: {SQLAssessment!.Points}. Taken: {SQLAssessment!.Taken}.";
                }
            if (CSharpAssessment is not null) {
                msg = msg + $"\n    {CSharpAssessment!.Topic} assessment points: {CSharpAssessment!.Points}. Taken: {CSharpAssessment!.Taken}.";
                }
            if (JavascriptAssessment is not null) {
                msg = msg + $"\n    {JavascriptAssessment!.Topic} assessment points: {JavascriptAssessment!.Points}. Taken: {JavascriptAssessment!.Taken}.";
                }
            if (AngularAssessment is not null) {
                msg = msg + $"\n    {AngularAssessment!.Topic} assessment points: {AngularAssessment!.Points}. Taken: {AngularAssessment!.Taken}.";
                }
            return msg;       
            }
        public void HappyAnniversary() {
            YearsOfService++;
            }
// end of methods
        public TQLStudent(string firstname, string lastname, int Years) { //creates new instance of student taking on these parameters
            FirstName = firstname;
            LastName = lastname;
            YearsOfService = Years;
            Id = NextId++; //since have two different constructors being used, both have to include this so ID increments properly
            }
        public TQLStudent() {  //more flexible-default constructor, allows inserting specific properties, good if lots of properties
            Id = NextId++;
            }
//end of constructors
    }

}
