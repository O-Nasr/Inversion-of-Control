namespace Inversion_of_Control.Dependency_Injection
{
    public class CustomerBusinessLogic
    {

        #region Constructor Injection
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess custDataAccess)
        {
            _dataAccess = custDataAccess;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
        #endregion



        #region Property Injection
        /*public ICustomerDataAccess DataAccess { get; set; }

        public CustomerBusinessLogic()
        {
        }

        public string ProcessCustomerData(int id)
        {
            return DataAccess.GetCustomerName(id);
        }*/

        #endregion
    }
}
