using ISP.Model;

namespace ISP.Principle
{
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}