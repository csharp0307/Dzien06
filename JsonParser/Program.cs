using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonParser
{
    class Program
    {

        class Employee
        {
            public int Id { get; set; }
            public String Name { get; set; }
        }

        static void Main(string[] args)
        {
            // serializacja danych z wykorzystaniem JSONa
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id=1, Name="Jan Kowalski" });
            empList.Add(new Employee() { Id=2, Name="Adam Nowak" });
            String s = JsonConvert.SerializeObject(empList);
            File.WriteAllText("c:/tmp/data.json", s);

            empList.Clear();
            s = File.ReadAllText("c:/tmp/data.json");
            // deserializacja
            empList = JsonConvert.DeserializeObject<List<Employee>>(s);
            

            String url = "http://dummy.restapiexample.com/api/v1/employees";
            WebClient webClient = new WebClient();
            String json = webClient.DownloadString(url);
            JObject jsonData = JObject.Parse(json);
            Console.WriteLine($"status={jsonData["status"]}, {jsonData["message"]}");

            foreach (JToken item in jsonData["data"])
            {
                int _id = Convert.ToInt32(item["id"]);
                string _name = item["employee_name"].ToString();
                double _salary = Convert.ToDouble(item["employee_salary"]);
                int _age = Convert.ToInt32(item["employee_age"]);
                string _image = item["profile_image"].ToString();

                Console.WriteLine($"{_id},{_name},{_salary},{_age},{_image}");
            }

            Console.ReadKey();
        }
    }
}
