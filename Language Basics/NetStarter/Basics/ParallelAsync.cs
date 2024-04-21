//Parallel Programming:
//multi-core: multiple CPUs physically parallely present
//technique to make use of these cpus in parallel
//.NET has TPL
//Asynchronous Programming:
//AJAX:
//non-blocking IO
//.NET : async , await
using System;
using System.Threading;
using System.Threading.Tasks;
class ParallelAsync
{
    int[] numbers = {23,56,89,234,543,890,4568,45987}; // instance field
    public void ProcessNumbers()
    {
        // sequential
        Console.WriteLine("Sequential implementation");
        foreach(var num in numbers)
        {
            DoWork(num);
        }

         Console.WriteLine("Parallel implementation");
        Parallel.ForEach(numbers ,  DoWork);
    }
   

    public void DoWork(int num)

    {
        Thread.Sleep(1000);// simulating delay
        Console.WriteLine($"Num:{num}");
    }
       


    // making tea
    // public async Task IgniteStove()
    // {
    //     await Task.Delay(5000);
    // }
    // public async Task PutkeatleyOnWithWater()
    // {
    //      await Task.Delay(5000);
    // }
    // public async Task GrindMasala()
    // {
    //      await Task.Delay(5000);
    // }
    // public void PourChiyapatti()
    // {

    // }
    // public void PourSugar()
    // {

    // }
    // public void PourMasala()
    // {

    // }
    // public void GrindMasala()

    // {

    // }
}
