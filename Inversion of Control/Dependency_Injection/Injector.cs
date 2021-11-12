namespace Inversion_of_Control.Dependency_Injection
{
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess()); // Constructor Injection


            //Property Injection
            /* _customerBL = new CustomerBusinessLogic();
             _customerBL.DataAccess = new CustomerDataAccess();*/
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.ProcessCustomerData(id);
        }
    }
}
