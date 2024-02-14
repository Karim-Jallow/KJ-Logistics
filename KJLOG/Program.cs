using System;
using System.Collections.Generic;

// Enum to represent user roles
public enum UserRole
{
    Admin,
    Agent,
    Customer
}


// User class to represent system users
public class User
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public UserRole Role { get; set; }
    public string Address { get; set; }

    public string ContactNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    
}

// Role class to represent user roles
public class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; }

    public DateTime CreatedDate { get; set; }
}

// DeliveryCompany class to represent the logistics company
public class DeliveryCompany
{
    public int Id { get; set; }

    public string CompanyName { get; set; }

    public string Address { get; set; }

    public string ContactNumber { get; set; }

    public string Email { get; set; }

    public DateTime CreatedDate { get; set; }
    
}
 // Sender's Address class to represent the sender's address
public class SendersAddress
{ 
    public int Id { get; set; }

    public string StreetAddress { get; set; }

    public string City { get; set; }
        
    public string Country { get; set; }

    public double GpsCoordinates { get; set; }

    public double IpAddress { get; set; }

    public string Landmark { get; set; }
   



}

    // Reciepient class to represent the reciepient
public class Reciepient
        {
    public int Id { get; set; }

    public string ReciepientFirstName { get; set; }

    public string ReciepientMiddleName { get; set; }

    public string ReciepientLastName { get; set; }

    public string NickName { get; set; }

    public string ContactNumber { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string Description { get; set; }
 }

// Order class to represent an order for delivery
public class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }
    
    public Reciepient Reciepient { get; set; }

    public double TotalWeight { get; set; }

    public string Description { get; set; }

    public double Length { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public SendersAddress SendersAddress { get; set; }

    public User Customer { get; set; }
    
    public Agent AssignedAgent { get; set; }

    public string OrderStatus { get; set; }
    
}

// Agent class to represent a logistics agent
public class Agent
{
    public int AgentId { get; set; }

    public string AgentName { get; set; }

    public string ContactNumber { get; set; }
    
    public DeliveryCompany AssignedCompany { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; }

   
}
