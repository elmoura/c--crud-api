using ApiCrud.Code.Students;

namespace ApiCrud.Code.Studants
{
    public static class StudentsRoutes
    {
        public static void addStudentRoutes(this WebApplication app)
        {
            app.MapGet("studants", () =>
            {
                return new Student("Gabriel");
            });
        }
    }
}
