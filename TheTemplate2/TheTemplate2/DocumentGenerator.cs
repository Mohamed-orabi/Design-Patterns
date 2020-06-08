using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTemplate2
{
   abstract class DocumentGenerator
    {
        public abstract void generateHeader();
        public abstract void generateBody();
        public abstract void generateDetails();

        public void generateDocument()
        {
            generateHeader();
            generateDetails();
            generateBody();
        }
    }

    class HTMLDocGenerator : DocumentGenerator
    {
        private string docDetails;

        public override void generateBody()
        {
            Console.WriteLine("<body>\n\n"+ docDetails + "</body>");
        }

        public override void generateDetails()
        {
            docDetails = "<header>\n\n </header>\n\n <footer>\n\n </footer>\n\n";
        }

        public override void generateHeader()
        {
            Console.WriteLine("<head>\n\n</head>");
        }
    }


    class XMLDocGenerator : DocumentGenerator
    {
        public string documentDetails;
        public override void generateDetails()
        {
            documentDetails = "<name>\n\nProduct one\n\n</name>";
        }
        public override void generateBody()
        {
            Console.WriteLine("<product>\n\n" + documentDetails + "\n\n</product>");
        }
        public override void generateHeader()
        {
            Console.WriteLine("<?xml version= " + 1.0 + " ?>");
        }
    }
}
