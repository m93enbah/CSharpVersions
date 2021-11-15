namespace NullPropagationPro
{
    //If the developer instead uses the?. (null-conditional) operator, the expression will evaluate to null instead of throwing an exception.
    class Program
    {
        static void Main(string[] args)
        {
            //1-teacherName is null if GetTeacher() returns null
            //var teacherName = classroom.GetTeacher()?.Name;

            //2-teacherName is null if GetTeacher() returns null OR classroom is null
            //var teacherName = classroom?.GetTeacher()?.Name;

            //3-compile time error: implicit conversion from bool? to bool not allowed
            //bool hasCertification = classroom?.GetTeacher()?.HasCertification;

            //4-works just fine, hasCertification will be null if any part of the chain is null
            //bool? hasCertification = classroom?.GetTeacher()?.HasCertification;

            //5-you can combine the null-conditional operator with the Null-coalescing Operator (??) to return a default value if the expression resolves to null
            //A-teacherName will be "No Name" when GetTeacher() 
            //B-returns null OR classroom is null OR Name is null
            //var teacherName = classroom?.GetTeacher()?.Name ?? "No Name";

            //6-you can use null propagation with indexer 
            //var firstStudentName = classroom?.Students?[0]?.Name;

            //7-you can use propagation with void functions
            //List<string> list = null;
            //list?.Add("hi");



            //Limitations

            //1-cannot use null propagation with property assigment , event subscription ,etc....
            // Error: The left-hand side of an assignment must be a variable, property or indexer
            //Process.GetProcessById(1337)?.EnableRaisingEvents = true;
            // Error: The event can only appear on the left hand side of += or -=
            //Process.GetProcessById(1337)?.Exited += OnProcessExited;


            //2-you have to make sure that the name is not null 
            //int? nameLength = person?.Name.Length;    
        }
    }
}
