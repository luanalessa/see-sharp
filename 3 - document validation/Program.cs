using System;

namespace _3___document_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("111.111.111-11");    
            Document doc1 = new Document("11111111111");    
            Document doc2 = new Document("123.456.789-09");    
            Document doc3 = new Document("12345678909");    
    
            Document doc4 = new Document("11111111111111");    
            Document doc5 = new Document("11.444.777/0001-61");    
            Document doc6 = new Document("59360748000148");    

        }
    }
}
