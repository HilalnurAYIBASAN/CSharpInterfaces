using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo;

class Program
{
    static void Main(string[] args)
    {
        IWorker[] workers = new IWorker[3] //bütün çalışalar hadi çalışın dedim burda
        {
            new Manager(),
            new Worker(),
            new Robot()
        };
        foreach (var worker in workers)
        {
            worker.Work();
        }

        IEat[] eats = new IEat[2] //bütün çalışalar hadi yemek yiyin dedim burda
        {
            new Manager(),
            new Worker()
        };
        foreach (var eat in eats)
        {
            eat.Eat();
        }

    }


}


interface IEat
{
    void Eat();
}
interface IWorker
{
    void Work();
}
interface IGetSalary
{
    void IGetSalary();
}

class Manager : IEat, IWorker, IGetSalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void IGetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Worker : IEat, IWorker, IGetSalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void IGetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}