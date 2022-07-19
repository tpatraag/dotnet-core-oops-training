class A {
  public string AProperty1 {get; set;}
  public string AProperty2 {get; set;}

  public void DoSomethingInA(){}
  public void DoSomethingElseInA(){}
}

class B: A {
  public string BProperty1 {get; set;}
  public string BProperty2 {get; set;}

  public void DoSomethingInB(){}
  public void DoSomethingElseInB(){}
}

/*
class B {
  public string AProperty1 {get; set;} --> Link to A.AProperty1
  public string AProperty2 {get; set;} --> Link to A.AProperty1
  public string BProperty1 {get; set;}
  public string BProperty2 {get; set;}

  public void DoSomethingInA(){}  --> Link to A.DoSomethingInA
  public void DoSomethingElseInA(){}  --> Link to A.DoSomethingElseInA
  public void DoSomethingInB(){}
  public void DoSomethingElseInB(){}
}
*/

// Program.cs
public class Program {
  public void main(){
   ✔ A a1 = new A(); 
   ✔ A a2 = new B(); // * Mother of all Oops inventions
   ❌ B b1 = new A(); 
   ✔ B b2 = new B();

   ✔ Scenario 1:
    a1.AProperty1;
    a1.DoSomethingElseInA();

    Scenario 2:
    a2.AProperty1;
    a2.DoSomethingElseInA();
    a2.BProperty1; ❌
    a2.DoSomethingElseInB(); ❌

   ❌ Scenario 3: // ! You can't even declare
    b1.AProperty1;
    b1.DoSomethingElseInA();

   ✔ Scenario 4:
    b2.AProperty1;
    b2.DoSomethingElseInA();
    b2.BProperty1;
    b2.DoSomethingElseInB();
  }
}
