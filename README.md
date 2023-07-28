# BridgeDesignPattern


This is a C# code example of Bridge Design Pattern. 

Here We are taking Payment Method to understand Bridge Structural Design Pattern.
Code Contains Following Folders:
  Implementor :
                Contanins an interface IPaymentSystem which contain one method ProcessPayment
  ConcreteImplementor:
                Contains two classes CityBankPaymentSystem and IDBIBankPaymentSystem which implements Implementor interface
  Abstraction : 
                Contains one abstract class Payment which contains one method MakePayment and initialize IPamentSystem interface
  RefinedAbstarction : 
                Contains two classes Card Payment and NetBanking Payment
