using System;

namespace OrderApp {

  public class Customer {

    public int CustomerId { get; set; }

    public string CustomerName { get; set; }

    public Customer() { }

    public Customer(int customerId, string customerName) {
      CustomerId = customerId;
      CustomerName = customerName;
    }

    public override string ToString() {
      return $"Id: {CustomerId}, Name: {CustomerName}";
    }

    public override bool Equals(object obj) {
      if (obj is Customer otherCustomer) {
        return CustomerId == otherCustomer.CustomerId;
      }
      return false;
    }

    public override int GetHashCode() {
      return 123456789 + CustomerId.GetHashCode();
    }
  }
}
