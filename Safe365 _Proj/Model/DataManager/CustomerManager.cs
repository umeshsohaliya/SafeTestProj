using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Safe365__Proj.DataAccess;
namespace Safe365__Proj.Model.DataManager
{

    public interface ICustomerManager
    {
        IEnumerable<Customer> GetAll();
        Customer Get(long id);
        void Add(Customer entity);
        void Update(Customer customer);
        void Delete(Customer employee);
    }


    public class CustomerManager: ICustomerManager
    {
        readonly Safe365Context _safe365Context;

        public CustomerManager(Safe365Context context)
        {
            _safe365Context = context;
        }


        public IEnumerable<Customer> GetAll()
        {
            return _safe365Context.Customers.ToList();
        }

        public Customer Get(long id)
        {
            return _safe365Context.Customers.FirstOrDefault(e => e.CustomerId == id);
        }

        public void Add(Customer entity)
        {
            _safe365Context.Customers.Add(entity);
            _safe365Context.SaveChanges();
        }

        public void Update( Customer customer)
        {
            //employee.FirstName = entity.FirstName;
            //employee.LastName = entity.LastName;
            //employee.DateOfBirth = entity.DateOfBirth;
            //employee.BusinessName = entity.BusinessName;
            //employee.DateCreated = entity.DateCreated;
            _safe365Context.Update(customer);
            _safe365Context.SaveChanges();
        }

        public void Delete(Customer employee)
        {
            _safe365Context.Customers.Remove(employee);
            _safe365Context.SaveChanges();
        }
    }
}
