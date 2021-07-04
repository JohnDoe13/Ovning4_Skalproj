using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


var result = GenerateNumbers(10)
    .Where(n =>
    { 
        return n % 2 == 0;
    })
    .Select(n =>{
    return n * 3;
});
foreach (var item in result)
{
    Console.WriteLine(item);
}

IEnumerable<int> GenerateNumbers(int maxvalue)
{
    //var result = new List<int>();
    for (var i = 0; i <= maxvalue; i++)
    {
        yield return i;
    }
    //return result;
}

