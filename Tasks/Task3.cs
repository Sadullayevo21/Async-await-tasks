using System;
using System.Threading.Tasks;

namespace Tasks;
public static class Task3
{
    public static async Task DisplayStudentInfoAsync()
    {
        Console.WriteLine("Fetching student information...");

        Task<string> nameTask = GetStudentNameAsync();
        Task<int> gradeTask = GetStudentGradeAsync();
        Task<int> attendanceTask = GetStudentAttendanceAsync();

        await Task.WhenAll(nameTask, gradeTask, attendanceTask);

        string name = nameTask.Result;
        int grade = gradeTask.Result;
        int attendance = attendanceTask.Result;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Attendance: {attendance}%");
    }

    private static async Task<string> GetStudentNameAsync()
    {
        await Task.Delay(2000);
        return "Ali";
    }

    private static async Task<int> GetStudentGradeAsync()
    {
        await Task.Delay(4000);
        return 92;
    }

    private static async Task<int> GetStudentAttendanceAsync()
    {
        await Task.Delay(3000);
        return 98;
    }
}