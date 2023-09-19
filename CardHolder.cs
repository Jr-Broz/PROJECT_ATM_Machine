using System;
public class CardHolder{

     public  String cardNum;
    int pin;
    String FirstName, LastName;
    double balance;

public CardHolder(String cardNum, int pin, string FirstName, string LastName, double balance){

    this.cardNum  = cardNum;
    this.pin = pin;
    this.FirstName = FirstName;
    this.LastName = LastName;
    this.balance = balance;

}
    public String getNum(){

        return cardNum;
    }

public int getPin(){

    return pin;
}

public string getFirstName(){

    return FirstName;
}

public string getLastName(){

    return LastName;
}

public double getBalance(){


    return balance;
}


public void setNum(String newCardNum){

    cardNum = newCardNum;
}

public void setPin(int newPin){

    pin = newPin;
}

public void setFirstName(String newFirstName){

    FirstName = newFirstName;
}

public void setLastName(String newLastName){

    LastName = newLastName;
}

public void setBalance(double newBalance){

    balance = newBalance;
}





}