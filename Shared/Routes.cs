namespace Shared
{
    public class Routes
    {
        public const string ClientsPrefix = "{clientId:maxlength(50)}";

        public class Home
        {
            public const string Login = "login";
        }

        public class Employee
        {
            public const string GetList = "employees";
            public const string Add = "employees/add";
            public const string Info = "employees/{id:int}";
            public const string Skills = "employees/{id:int}/skills";
            public const string AssignedProjects = "employees/{id:int}/projects";
        }
        public class Project
        {
            public const string GetList = "projects";
            public const string Add = "projects/add";
            public const string Info = "projects/{id:int}";
            public const string AssignedEmployee = "projects/{id:int}/employees";

        }
        public class Profile
        {
            public const string MainInfo = "profile";
            public const string Skills = "profile/skills";
        }
    }
}
