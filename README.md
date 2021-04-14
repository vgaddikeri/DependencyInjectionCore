# DependencyInjectionCore
Simple example of Dependency Injection

Implementation using .NET Core
The .NET Core supports the DI design pattern. All we have to do is to register the mappings (Interface service with the concrete class) in ‘ConfigureServices’ method in the Startup class. This method is called during the runtime and the concrete class gets instantiated.

The CustomerController class constructor takes interface variable as parameter to initialize the private member. ICustomerService is mapped to CustomerService concrete class and hence the CustomerService class gets initialized. CustomerService class accepts ICustomerRepository, an interface variable mapped to CustomerRepository concrete class. This CustomerRepository class returns the data in JSON format, which can be read with either Postman or Fiddler.

