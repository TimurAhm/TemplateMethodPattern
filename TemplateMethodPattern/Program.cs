internal class Program
{
    private static void Main(string[] args)
    {
        School school = new School();
        Univesity univesity = new Univesity();

        school.Learn();
        Console.WriteLine(new String('-', 30));
        univesity.Learn();
        
        Console.ReadKey();
    }
}

//abstract class AbstractClass
//{
//    public void TemplateMethod()
//    {
//        Operation1();
//        Operation2();
//    }

//    public abstract void Operation1();
//    public abstract void Operation2();
//}

//class ConcreteClass : AbstractClass
//{
//    public override void Operation1()
//    {    }

//    public override void Operation2()
//    {    }
//}

abstract class Education
{
    public void Learn()
    {
        Enter();
        Study();
        PassExams();
        GetDocument();
    }

    public abstract void Enter();
    public abstract void Study();
    public virtual void PassExams()
    {
        Console.WriteLine("Сдача выпускных экзаменов");
    }
    public abstract void GetDocument();
}

class School : Education
{
    //public new void Learn()
    //{
    //    Console.WriteLine("Тут можно переопеределить метод и да, выйдет то - что тут"); 
    //}

    public override void Enter()
    {
        Console.WriteLine("Идем первый раз в школу");
    }
    
    public override void Study()
    {
        Console.WriteLine("Посещаем уроки, домашка и прочая дичь школы");
    }

    public override void GetDocument()
    {
        Console.WriteLine("Получаем аттестат о среднем общем");
    }

    public void GradersMeet()
    {
        Console.WriteLine("Выпускники встречаются через 10 лет");
    }
}

class Univesity : Education
{
    public override void Enter()
    {
        Console.WriteLine("Сдаем вступительные и поступаем в ВУЗ");
    }

    public override void Study()
    {
        Console.WriteLine("Посещаем лекции");
        Console.WriteLine("Проходим практику");
    }

    public override void PassExams()
    {
        Console.WriteLine("Сдаём экзамен по специальности");
    }

    public override void GetDocument()
    {
        Console.WriteLine("Получаем диплом о вышке");
    }

}