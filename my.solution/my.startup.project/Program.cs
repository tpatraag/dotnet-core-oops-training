using my.solution/my.project;

namespace my.solution/my.startup.project {
  public class Program {
    public int main(string[] args) {
      MyProjectContext _context = new MyProjectContext();

      _context.AProperty1;
      _context.DoSomethingElseInA();
      _context.BProperty1;
      _context.DoSomethingElseInB();
    }
  }
}
