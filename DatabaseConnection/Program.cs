using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace XMLConnection
{
    class Program
    {
       string filePath = @"C:\Users\10084148\OneDrive - Dover Corporation\Desktop\DIPL\Training Docs\Technical\C#\Training\DatabaseConnection\StudentDetail.xml";
     

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.writeStudentDetailsToXml();
        }
        public void writeStudentDetailsToXml()
        {
            
            DataSet d = new DataSet(); //Create Data-Set
            d.Namespace = "StudentData"; //Create Namespace(Not-Mandatory)
            DataTable dataTable = new DataTable("StudentDetails"); //Create Data-Table
            d.Tables.Add(dataTable); // Add Data-Table to Data-Set


            // Create Columns
            DataColumn c1 = new DataColumn("Name");
            DataColumn c2 = new DataColumn("DOB");
            DataColumn c3 = new DataColumn("Class");
            DataColumn c4 = new DataColumn("School Name");
                       
            // Add Columns to Data-Table
            dataTable.Columns.Add(c1);
            dataTable.Columns.Add(c2);
            dataTable.Columns.Add(c3);
            dataTable.Columns.Add(c4);


            // Adding 1st ROW
            DataRow r1 = dataTable.NewRow(); // Create Row
            r1["Name"] = "Rahul"; // Assign Vaules into Rows
            r1["DOB"] = "12-12-2006";
            r1["Class"] = "Std-10";
            r1["School Name"] = "ABC Public School";

            dataTable.Rows.Add(r1); //Add Rows to Data-Table

            // Adding 2nd ROW
            
            DataRow r2 = dataTable.NewRow();
            r2["Name"] = "Sourav";
            r2["DOB"] = "31-01-2009";
            r2["Class"] = "Std-6";
            r2["School Name"] = "DEF Public School";

            dataTable.Rows.Add(r2);

            // Adding 3rd ROW
          
            DataRow r3 = dataTable.NewRow();
            r3["Name"] = "Mayank";
            r3["DOB"] = "08-12-2015";
            r3["Class"] = "Std-4";
            r3["School Name"] = "GHI Public School";

            dataTable.Rows.Add(r3);

            

            d.AcceptChanges(); // To reflect and add changes
            d.WriteXml(filePath); // Writing to XML File

            Console.WriteLine("COMPLETED");
        }

        public void readXML()
        {
            var xmlDocument = new XmlDocument();
            var xmlDataDocument = new XmlDataDocument();

            using (var sr = new StreamReader(filePath))
            {
                XmlDataDocument.DataSet.ReadXml(filePath);
                DataSet dataSet = XmlDataDocument.DataSet;
                DataSet dataTable = dataSet.Tables[0];

                for(int i=0; i<dataTable.Rows.Count; i++)
                {
                    Console.WriteLine(dataTable.Rows[i]["author"]);

                }
            }


            

            


        }
    }
}
