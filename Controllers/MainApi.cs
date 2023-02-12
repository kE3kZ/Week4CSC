using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Lecture3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainApi : ControllerBase
    {

        [HttpPost(Name = "GetStandardDeviation")]
        public ActionResult<List<string>> IntListWork(List<int> lint)
        {
            List<string> slist = new List<string>();
            double sum = 0;
            double counter = 0;
            double sumSR = 0;
            double csd;
            
            lint.Sort();

            try
            {
                foreach (int i in lint)
                {
                    if (counter <= 0)
                    {
                        counter++;
                        sum += i;
                        sumSR = i * i;
                        csd = Math.Sqrt((sumSR - sum * sum / counter) / (counter - 1));
                        slist.Add("List too small");
                        System.Console.WriteLine(LogObject(i));
                    }
                    else {
                        counter++;
                        sum += i;
                        sumSR = i * i;
                        csd = Math.Sqrt((sumSR - sum * sum / counter) / (counter - 1));
                        slist.Add("Elements: " + counter + " Current Standard Deviation: " + csd);
                        Console.WriteLine(LogObject(i));
                    }
                    
                }

         
            } 
            catch(Exception e) 
            {
                Console.WriteLine("Error: Something went wrong.");
            }
            return Accepted(slist);
        }   
    int LogObject(int slist) 
        {
            return slist;
        }
    }
    

}