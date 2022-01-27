using System;

public class Customer {
    private string firstname;
    private string lastname;
    private int ordernum;

    public string Firstname {get;set;}
    public string Lastname {get;set;}
    public int OrderNum {get;set;}

    public Customer(string firstname, string lastname, int ordernum){
        this.firstname = firstname;
        this.lastname = lastname;
        this.ordernum = ordernum;
    } 

    public Customer(){

    }

    public override string ToString()
    {
        return "Order number of customer " + firstname + " " + lastname + " is: " + ordernum + ".";
    }

}